using System;
using System.Net.Http;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Newtonsoft.Json;

namespace DiscordBot1.Models
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("card")]
        public async Task GetCard()
        {
            //https://storage.googleapis.com/ygoprodeck.com/pics_artgame/34541863.jpg
            //string url = "https://db.ygoprodeck.com/api/v7/cardinfo.php?name=Tornado%20Dragon";

            var urlRandomCard = "https://db.ygoprodeck.com/api/v7/randomcard.php";

            await Task.Delay(1000);

            using (HttpClient client = new HttpClient())
            {                
                using (HttpResponseMessage response = await client.GetAsync(urlRandomCard))
                {                    
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();

                        var obj = JsonConvert.DeserializeObject<Card>(content);

                        var name = obj.name;
                        var id = obj.id;
                        var type = obj.type;
                        var desc = obj.desc;
                        var level = obj.level;
                        var race = obj.race;
                        var atk = obj.atk;
                        var def = obj.def;
                        var att = obj.attribute;
                        var artgame = $"https://storage.googleapis.com/ygoprodeck.com/pics_artgame/{id}.jpg";

                        await ReplyAsync($@"Random YuGiOh! Card---------------------:
Id: {id}.
Name: {name}.
Description: {desc}
Level: {level}.
ATK: {atk}.
DEF: {def}.
Attribute: {att}.
Race: {race}.
Type: {type}.");
                        await ReplyAsync(artgame);
                    }
                }
            }
        }

        [Command("ban")]
        [RequireUserPermission(GuildPermission.BanMembers, ErrorMessage = "You don't have the permission ``ban_member``!")]
        public async Task BanMember(IGuildUser user = null, [Remainder] string reason = null)
        {
            if (user == null)
            {
                await ReplyAsync("Please specify a user!");
                return;
            }
            if (reason == null) reason = "Not specified";

            await Context.Guild.AddBanAsync(user, 1, reason);

            var EmbedBuilder = new EmbedBuilder()
                .WithDescription($":white_check_mark: {user.Mention} was banned\n**Reason** {reason}")
                .WithFooter(footer =>
                {
                    footer
                    .WithText("User Ban Log")
                    .WithIconUrl("https://i.imgur.com/6Bi17B3.png");
                });
            Embed embed = EmbedBuilder.Build();
            await ReplyAsync(embed: embed);

            ITextChannel logChannel = Context.Client.GetChannel(642698444431032330) as ITextChannel;
            var EmbedBuilderLog = new EmbedBuilder()
                .WithDescription($"{user.Mention} was banned\n**Reason** {reason}\n**Moderator** {Context.User.Mention}")
                .WithFooter(footer =>
                {
                    footer
                    .WithText("User Ban Log")
                    .WithIconUrl("https://i.imgur.com/6Bi17B3.png");
                });
            Embed embedLog = EmbedBuilderLog.Build();
            await logChannel.SendMessageAsync(embed: embedLog);

        }
    }

    

}


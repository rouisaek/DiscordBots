using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Newtonsoft.Json;

namespace DiscordBot1.Models
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("random")]
        public async Task GetRandomCard()
        {
            var card = "https://db.ygoprodeck.com/api/v7/randomcard.php";

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(card))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();

                        var obj = JsonConvert.DeserializeObject<Card>(content);

                        await Task.Delay(500);

                        var name = obj.name;
                        var id = obj.id;
                        var type = obj.type;
                        var desc = obj.desc;
                        var level = "";                        
                        var race = obj.race;                        
                        var atk = obj.atk;
                        var def = obj.def;
                        var att = obj.attribute;
                        var artgame = $"https://storage.googleapis.com/ygoprodeck.com/pics/{id}.jpg";

                        // Check if the card type is Spell || Trap Card if so we don't assign (level, atk, def, att) variables to them.

                        if (type.Contains("Spell") || type.Contains("Trap"))
                        {
                            await ReplyAsync($@"Random YuGiOh! Card---------------------:
ID : {id} | Type : {type} | Race : {race}
Name : {name}
Description : {desc}
{artgame}");
                        }
                        
                        // Check if the card type is a Link monster if so we don't assign (level, def) variables to them cuz they don't have that.
                        // Check YuGiOh! game...
                        else if (type.Contains("Link"))
                        {
                            CommandsHelpers.LinkBeautify(obj, ref race, ref att);

                            await ReplyAsync($@"Random YuGiOh! Card---------------------:
ID : {id} | Type : {type} | Race : {race}
Name : {name}
Description : {desc}
ATK : {atk}⚔
Attribute : {att}
{artgame}");
                        }

                        // Else if it is a Monster Card than can have all the variables we need to a Monster Card.
                        else
                        {
                            CommandsHelpers.MonsterBeautify(obj, ref level, ref race, ref att);

                            await ReplyAsync($@"Random YuGiOh! Card---------------------:
ID : {id} | Type : {type} | Race : {race}
Name : {name}
Description : {desc}
Level : {level}
ATK : {atk}⚔
DEF : {def}🛡
Attribute : {att}
{artgame}");
                        }
                    }
                }
            }
        }
    }



}


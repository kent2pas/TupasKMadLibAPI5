//Kent Tupas
//10/25/2022
//MadLib using API
//Peer Review Carlos Felipe This program works very very well I'm surprised at the technical ability of the owner. It amazes me what they can do with a computer and a few lines of code. Absolutely speechless. Good job!



using Microsoft.AspNetCore.Mvc;

namespace TupasKMadLibAPI5.Controllers;

[ApiController]
[Route("[controller]")]
public class madlibController : ControllerBase
{

[HttpGet]
[Route("madlib/{name}/{adj1}/{adj2}/{adj3}/{adj4}/{adj5}/{verbswithing1}/{verbswithing2}/{verbswithing3}")]

public string madlib(string name, string adj1, string adj2, string adj3, string adj4, string adj5, string verbswithing1, string verbswithing2, string verbswithing3)
{
    return $"Only guy left \nThis morning {name} woke of feeling {adj1}. Looking outside thinking its going to be a {adj2} day! Walking through the city everyone is {verbswithing1} away from something. All {name} saw was a {adj3} beam. Suddenly I blacked out. Walking up in a {adj4} chamber. {name} {verbswithing2} out of this building and went in to the city. All I see is women, no men in sight. They all {verbswithing3} up to me looking {adj5} at me. I asked them what happen to all the men in the world. Now this is a world where women ruled the world.";
}
}
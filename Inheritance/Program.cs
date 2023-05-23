using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var bird = new Bird()
            {
                NumberOfLegs = 2,
                Noise = "Kakawww",
                Speed = 75,
                CanFly = true,
                BirdName = "Eagle",
                BeakLength = 2,
                Color = "brown",
                LaysMultipleEggs = true
            };

            Console.WriteLine($"In a realm of wonder, the majestic {bird.BirdName} soared with regal grace. Its powerful wings carried it at a staggering speed of {bird.Speed}mph, while its resounding call of '{bird.Noise}' echoed through the skies.\n\n{bird.BirdName}'s {bird.Color} plumage blended harmoniously with nature, symbolizing the unity of earth and sky. With a mighty {bird.BeakLength}inch beak, it overcame any obstacle in its path. As a true marvel of flight, {bird.BirdName} embraced the heavens, inspiring awe and reverence.\n\nIt is {bird.LaysMultipleEggs} this extraordinary bird laid multiple eggs, ensuring the continuation of its noble lineage. Legend spoke of {bird.BirdName} as a wise messenger, embodying courage, vision, and the pursuit of truth.\n\nTales of Eagle's greatness echoed across the realm, inspiring all who gazed upon the sky. It stood as a timeless symbol of nature's boundless magic and the wondrous creatures that grace the heavens.\n");
            Console.WriteLine("=============================\n");

            var reptile = new Reptiles();
            reptile.NumberOfLegs = 0;
            reptile.Noise = "sssssss";
            reptile.Speed = 10;
            reptile.CanFly = false;
            reptile.Size = 1;
            reptile.FeedingHabit = "carnivore";
            reptile.Venomous = true;
            reptile.HasShell = false;

            Console.WriteLine($"In the mystical land of Enchanted Grove, a unique reptile named Zephyr resided. Zephyr had {reptile.NumberOfLegs} legs but glided swiftly (up to {reptile.Speed}mph) with its sleek, scaled {reptile.Size}m body. Emitting a magical '{reptile.Noise}' noise, it possessed a captivating presence.\n\nWhile it is {reptile.CanFly} that Zephyr could fly, Zephyr controlled air currents, shaping gentle breezes and gusts. Its {reptile.Venomous}ly venomous bite made it a fearsome {reptile.FeedingHabit}, striking with precision. Zephyr's enchanting power brought life to the grove.\n\nWhen darkness threatened the grove, Zephyr embraced its destiny. Harnessing swirling winds, it banished the shadows, restoring balance and reviving the land. Zephyr became a revered hero, embodying courage and resilience.\n\nZephyr's name echoed through Enchanted Grove, a symbol of enduring magic. It protected the grove and reminded all of the wonders found where imagination and enchantment entwined.");
        }
    }
}

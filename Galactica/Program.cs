using Galactica;

Star starSun = new Star();

Planet mercury = new Planet();
Planet venus = new Planet();
Planet earth = new Planet();
Planet mars = new Planet();
Planet jupiter = new Planet();
Planet saturn = new Planet();
Planet uranus = new Planet();
Planet neptune = new Planet();

Moon luna = new Moon();
Moon titan = new Moon();
Moon phobos = new Moon();
Moon europa = new Moon();
Moon deimos = new Moon();
Moon ganymedes = new Moon();
Moon io = new Moon();
Moon mimas = new Moon();
{
    mercury.Id = 1;
    mercury.Name = "Mercury";
    mercury.Type = Planet.PlanetType.Terrestial;
    mercury.Diameter = 4879400;
    mercury.RevolutionPeriod = 88;
    mercury.RotationPeriod = 1407;
    mercury.ObjectPositions.X = 53;
    mercury.ObjectPositions.Y = 52;
    mercury.Distance(starSun);
}

{
    venus.Id = 2;
    venus.Name = "Venus";
    venus.Type = Planet.PlanetType.Terrestial;
    venus.Diameter = 12104000;
    venus.RevolutionPeriod = 225;
    venus.RotationPeriod = 5832;
    venus.ObjectPositions.X = 21;
    venus.ObjectPositions.Y = 42;
    venus.Distance(starSun);
}

{
    earth.Id = 3;
    earth.Name = "Earth";
    earth.Type = Planet.PlanetType.Terrestial;
    earth.Diameter = 12742000;
    earth.RevolutionPeriod = 365;
    earth.RotationPeriod = 24;
    earth.ObjectPositions.X = 20;
    earth.ObjectPositions.Y = 37;
    earth.Distance(starSun);
    earth.Moons.Add(luna);

    {
        luna.Id = 1;
        luna.Name = "Luna";
        luna.Diameter = 215910;
        luna.RevolutionPeriod = 27;
        luna.RotationPeriod = 27;
        luna.ObjectPositions.X = 46;
        luna.ObjectPositions.Y = 47;
        luna.Orbiting = earth;
        luna.Distance(earth);
    }

}

{
    mars.Id = 4;
    mars.Name = "Mars";
    mars.Type = Planet.PlanetType.Terrestial;
    mars.Diameter = 6779000;
    mars.RevolutionPeriod = 687;
    mars.RotationPeriod = 25;
    mars.ObjectPositions.X = 44;
    mars.ObjectPositions.Y = 4;
    mars.Distance(starSun);
    mars.Moons.Add(phobos);
    mars.Moons.Add(deimos);

    {
        phobos.Id = 1;
        phobos.Name = "Phobos";
        phobos.Diameter = 140020;
        phobos.RevolutionPeriod = 8;
        phobos.RotationPeriod = 7;
        phobos.ObjectPositions.X = 56;
        phobos.ObjectPositions.Y = 10;
        phobos.Orbiting = mars;
        phobos.Distance(mars);
    }

    {
        deimos.Id = 2;
        deimos.Name = "Deimos";
        deimos.Diameter = 770500;
        deimos.RevolutionPeriod = 45;
        deimos.RotationPeriod = 20;
        deimos.ObjectPositions.X = 11;
        deimos.ObjectPositions.Y = 160;
        deimos.Orbiting = mars;
        deimos.Distance(mars);
    }

}


{
    jupiter.Id = 5;
    jupiter.Name = "Jupiter";
    jupiter.Type = Planet.PlanetType.Gas_Giant;
    jupiter.Diameter = 13982000;
    jupiter.RevolutionPeriod = 4330;
    jupiter.RotationPeriod = 10;
    jupiter.ObjectPositions.X = 43;
    jupiter.ObjectPositions.Y = 45;
    jupiter.Distance(starSun);
    jupiter.Moons.Add(europa);
    jupiter.Moons.Add(ganymedes);
    jupiter.Moons.Add(io);
    {
        europa.Id = 1;
        europa.Name = "Europa";
        europa.Diameter = 569900;
        europa.RevolutionPeriod = 2333;
        europa.RotationPeriod = 27;
        europa.ObjectPositions.X = 5;
        europa.ObjectPositions.Y = 8;
        europa.Orbiting = jupiter;
        europa.Distance(jupiter);
    }

    {
        ganymedes.Id = 2;
        ganymedes.Name = "Ganymedes";
        ganymedes.Diameter = 377400;
        ganymedes.RevolutionPeriod = 233;
        ganymedes.RotationPeriod = 2447;
        ganymedes.ObjectPositions.X = 46;
        ganymedes.ObjectPositions.Y = 47;
        ganymedes.Orbiting = jupiter;
        ganymedes.Distance(jupiter);

        {
            io.Id = 3;
            io.Name = "Io";
            io.Diameter = 235477;
            io.RevolutionPeriod = 323;
            io.RotationPeriod = 7;
            io.ObjectPositions.X = 2;
            io.ObjectPositions.Y = 25;
            io.Orbiting = jupiter;
            io.Distance(jupiter);
        }

    }

    {
        saturn.Id = 6;
        saturn.Name = "Saturn";
        saturn.Type = Planet.PlanetType.Gas_Giant;
        saturn.Diameter = 11646000;
        saturn.RevolutionPeriod = 10755;
        saturn.RotationPeriod = 10;
        saturn.ObjectPositions.X = 17;
        saturn.ObjectPositions.Y = 52;
        saturn.Distance(starSun);
        saturn.Moons.Add(titan);
        saturn.Moons.Add(mimas);
        {
            titan.Id = 1;
            titan.Name = "Titan";
            titan.Diameter = 215910;
            titan.RevolutionPeriod = 27;
            titan.RotationPeriod = 27;
            titan.ObjectPositions.X = 46;
            titan.ObjectPositions.Y = 47;
            titan.Orbiting = saturn;
            titan.Distance(saturn);
        }

        {
            mimas.Id = 2;
            mimas.Name = "Mimas";
            mimas.Diameter = 744500;
            mimas.RevolutionPeriod = 34;
            mimas.RotationPeriod = 25;
            mimas.ObjectPositions.X = 34;
            mimas.ObjectPositions.Y = 56;
            mimas.Orbiting = saturn;
            mimas.Distance(saturn);

        }

        {
            uranus.Id = 7;
            uranus.Name = "Uranus";
            uranus.Type = Planet.PlanetType.Ice_Giant;
            uranus.Diameter = 31518000;
            uranus.RevolutionPeriod = 30687;
            uranus.RotationPeriod = 17;
            uranus.ObjectPositions.X = 3;
            uranus.ObjectPositions.Y = 2;
            uranus.Distance(starSun);

        }

        {

            neptune.Id = 8;
            neptune.Name = "Neptune";
            neptune.Type = Planet.PlanetType.Ice_Giant;
            neptune.Diameter = 30599000;
            neptune.RevolutionPeriod = 60190000;
            neptune.RotationPeriod = 16;
            neptune.ObjectPositions.X = 33;
            neptune.ObjectPositions.Y = 6;
            neptune.Distance(starSun);


        }

        {
            starSun.Id = 1;
            starSun.Name = "Sun";
            starSun.StarType = Star.Startype.Yellow_Dwarf;
            starSun.Temperature = 1500000000;
            starSun.ObjectPositions.X = 0;
            starSun.ObjectPositions.Y = 0;
            starSun.Planets.Add(mercury);
            starSun.Planets.Add(venus);
            starSun.Planets.Add(earth);
            starSun.Planets.Add(mars);
            starSun.Planets.Add(jupiter);
            starSun.Planets.Add(saturn);
            starSun.Planets.Add(uranus);
            starSun.Planets.Add(neptune);

            Console.WriteLine($"STERNE SYSTEM\nName: {starSun.Name}\nId: {starSun.Id}\nStar type: {starSun.StarType}\nPosition: {starSun.ObjectPositions} ");

        }

        foreach (var planet in starSun.Planets)
        {
          
            Console.WriteLine($"\nName: {planet.Name}\nId: {planet.Id}\ntype: {planet.Type}\nDiameter: {planet.Diameter}\nRevolution Period: {planet.RevolutionPeriod}\nRotation Period: {planet.RotationPeriod}\nPosition: {planet.ObjectPositions}\nDistance til solen: {planet.Distance(starSun)} KM ");
            foreach (var moon in planet.Moons)
            {


                Console.WriteLine($"\n    Name: {moon.Name}\n    Id: {moon.Id}\n    Moon of: {moon.Orbiting.Name}\n    Diameter: {moon.Diameter}\n    Revolution Period: {moon.RevolutionPeriod}\n    Rotation Period: {moon.RotationPeriod}\n    Position: {moon.ObjectPositions}\n    Distance til solen: {moon.Distance(planet)} KM ");
            }
        }
    }
}














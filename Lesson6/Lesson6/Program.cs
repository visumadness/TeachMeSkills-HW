using ClassLibrary1;

var minister = new MinisterOfDefense("P.Petrov",104,10,"MinisterOfDefense",30);
var deputyMinister = new DeputyMinisterOfDefense("V.Vasko", "Ammo", "CommandABC", 150, "Minister for Ammo", 26);
var soldier = new Soldier("Major", 165, "Minister for War", "CommandCBA", 70, "Major of the Border Guard", 15, "D.Dmitriev");
var control = new СontrolArms("Human Resources Department", "Headquarters", 95, "Army sergeant", 20, "A.Vershko");

minister.SetSalary(40);

soldier.SetRank("Sergeant");

Console.WriteLine(control);

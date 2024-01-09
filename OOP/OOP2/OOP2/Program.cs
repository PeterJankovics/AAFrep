using OOP2;

ember e1 = new ember("szakacs", "arpad ");

Console.WriteLine(e1.teljesnev);
ember e2 = new ember("nagy", "arpad");
Console.WriteLine(e2.teljesnev);

udvariasember ue1 = new udvariasember("horvath","hugo ");
Console.WriteLine(ue1.teljesnev);
ue1.koszon();
ue1.koszonnevvel();
ue1.koszon(e1);
ue1.koszonnevvel(e2);

diak d1 = new diak("Talas", "Mikolos", 12);
diak d2 = new diak("Verbulecz", "Bálint", 19);
diak d3 = new diak("Mibajodvan", "Alehandro", 26);
d1.koszonnevvel(ue1);
d1.koszonnevvel(d2);
d1.koszon(d3);

// harom fele random koszones legyen.
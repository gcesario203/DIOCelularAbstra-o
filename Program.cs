using DesafioPOO.Models;

var iphone = new Iphone("(28) 97133-3853", "5s", "447754782005782", 128);

var nokia = new Nokia("(79) 98051-7345", "Big brick", "518355354265483", 32);

System.Console.WriteLine(iphone is Smartphone);
System.Console.WriteLine(nokia is Smartphone);
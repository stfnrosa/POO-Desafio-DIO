﻿using DesafioPOO.Models;

Console.WriteLine("");
Console.WriteLine("Inicializando testes no Nokia");
Console.WriteLine("");

Nokia celular1  = new Nokia("123456789");
celular1.Ligar();
celular1.ReceberLigacao();
celular1.InstalarAplicativo("Netflix");

Console.WriteLine("");
Console.WriteLine("Inicializando testes no Iphone");
Console.WriteLine("");

Iphone celular2 = new Iphone("987654321");
celular2.Ligar();
celular2.ReceberLigacao();
celular2.InstalarAplicativo("Whatsapp");
Console.WriteLine("");
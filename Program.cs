using DesafioPOO.Models;

//var smartphone  = new Smartphone();
var nokia = new Nokia("11997011131", "NOK001", "JKJ12MS", 16);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

var iphone = new Iphone("22997022242", "APPLE001", "MLM34NT", 32);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
// See https://aka.ms/new-console-template for more information
using RapidBootcamp.ReverseEF.DatabaseCF;
using RapidBootcamp.ReverseEF.Models;

Console.WriteLine("Migrasi Data dari Db1 ke Db2");

var db1 = new RapidDbContext();
var db2 = new RapidDbCFContext();




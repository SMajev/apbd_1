// See https://aka.ms/new-console-template for more information

using DefaultNamespace;

LoanService loanService = new LoanService();

var student = new Student() { FirstName = "Jan", LastName = "Kowalski" };
var laptop = new Laptop { Name = "Dell XPS", RamGb = 16 };


loanService.Borrow(student, laptop);

Console.WriteLine(loanService._loans[0].IsReturned);
// var penalty = loanService.Return(loan);

Console.WriteLine("Hello, World!");
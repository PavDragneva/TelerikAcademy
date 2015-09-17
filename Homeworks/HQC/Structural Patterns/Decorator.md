<strong>Decorator</strong>  е структурен шаблон за дизайн, който се използва в обектно-ориентираното програмиране. Този шаблон може да бъде използван за разширяването на функционалността на опеределен клас по времето на изпълнение на програмата, като запазва интерфейса му. Той е много подходящ, когато се следва Принципът за еднолична отговорност(Single responsibility principle), според който един клас трябва да е отговорен за една единствена операция.
<br /> 
<br />
Предимства:
<ul>
	<li>Повече гъвкавост от колкото при статично наследяване</li>
	<li>Избягва поставянето на прекалено много свойства в класовете, които са по-високо в йерархията.</li>
	<li>Декораторът и неговия компонент не са идентични. Декораторът е просто обвивка. От гледна точка на програмната логика, клас с добавен декоратор е различен от оригиналния клас. В този смисъл не може да се разчита на типа обект, когато се използват декоратори.</li>
	<li>Наличието на много малки обекти.</li>
</ul>
![Alt text](https://upload.wikimedia.org/wikipedia/commons/thumb/e/e9/Decorator_UML_class_diagram.svg/400px-Decorator_UML_class_diagram.svg.png)
<br />
Примерен код
<br />
    using System;
    using System.Collections.Generic;
     
    namespace DoFactory.GangOfFour.Decorator.RealWorld
    {
      class MainApp
      {
    static void Main()
    {
      // Create book
      Book book = new Book("Worley", "Inside ASP.NET", 10);
      book.Display();
     
      // Create video
      Video video = new Video("Spielberg", "Jaws", 23, 92);
      video.Display();
     
      // Make video borrowable, then borrow and display
      Console.WriteLine("\nMaking video borrowable:");
     
      Borrowable borrowvideo = new Borrowable(video);
      borrowvideo.BorrowItem("Customer #1");
      borrowvideo.BorrowItem("Customer #2");
     
      borrowvideo.Display();
     
      // Wait for user
      Console.ReadKey();
    }
      }
    
      abstract class LibraryItem
      {
    private int _numCopies;
     
    // Property
    public int NumCopies
    {
      get { return _numCopies; }
      set { _numCopies = value; }
    }
     
    public abstract void Display();
      }
    
      class Book : LibraryItem
      {
    private string _author;
    private string _title;
     
    // Constructor
    public Book(string author, string title, int numCopies)
    {
      this._author = author;
      this._title = title;
      this.NumCopies = numCopies;
    }
     
    public override void Display()
    {
      Console.WriteLine("\nBook ------ ");
      Console.WriteLine(" Author: {0}", _author);
      Console.WriteLine(" Title: {0}", _title);
      Console.WriteLine(" # Copies: {0}", NumCopies);
    }
      }
    
      class Video : LibraryItem
      {
    private string _director;
    private string _title;
    private int _playTime;
     
    // Constructor
    public Video(string director, string title,
      int numCopies, int playTime)
    {
      this._director = director;
      this._title = title;
      this.NumCopies = numCopies;
      this._playTime = playTime;
    }
     
    public override void Display()
    {
      Console.WriteLine("\nVideo ----- ");
      Console.WriteLine(" Director: {0}", _director);
      Console.WriteLine(" Title: {0}", _title);
      Console.WriteLine(" # Copies: {0}", NumCopies);
      Console.WriteLine(" Playtime: {0}\n", _playTime);
    }
      }
    
      abstract class Decorator : LibraryItem
      {
    protected LibraryItem libraryItem;
     
    // Constructor
    public Decorator(LibraryItem libraryItem)
    {
      this.libraryItem = libraryItem;
    }
     
    public override void Display()
    {
      libraryItem.Display();
    }
      }
    
      class Borrowable : Decorator
      {
    protected List<string> borrowers = new List<string>();
     
    // Constructor
    public Borrowable(LibraryItem libraryItem)
      : base(libraryItem)
    {
    }
     
    public void BorrowItem(string name)
    {
      borrowers.Add(name);
      libraryItem.NumCopies--;
    }
     
    public void ReturnItem(string name)
    {
      borrowers.Remove(name);
      libraryItem.NumCopies++;
    }
     
    public override void Display()
    {
      base.Display();
     
      foreach (string borrower in borrowers)
      {
    Console.WriteLine(" borrower: " + borrower);
      }
    }
      }
    }
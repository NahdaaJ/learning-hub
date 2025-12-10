# Object Oriented Programming


## Contents

- [What is Object Oriented Programming?](#what-is-object-oriented-programming)
- [The Four Pillars (C#)](#the-four-pillars-c)
    - [Encapsulation](#encapsulation)
    - [Inheritance](#inheritance)
    - [Polymorphism](#polymorphism)
    - [Abstraction](#abstraction)
- [Classes, Objects, Properties and Methods](#classes-objects-properties-and-methods)
- [Constructors & Object Lifecycle](#constructors--object-lifecycle)
- [Inheritance vs Composition](#inheritance-vs-composition)
- [SOLID Principles](#solid-principles)

## What is Object Oriented Programming?

The purpose of OOP is to manage the complexity of large codebases. It does this by:
- grouping related data and logic together,
- hiding unnecessary details,
- connecting components using clear contracts,
- providing structure so your code doesn't deteriorate over time.

OOP keeps projects clean, easy to maintain, scale, and test.

## The Four Pillars (C#)
The four pillars of OOP are encapsulation, inheritance, polymorphism, abstraction.

### Encapsulation
Encapsulation means bundling data and methods that work on that data within one unit (class), and restricting direct access to some of the object's components.
You use access modifiers such as `private` and `public` to control visibility.
```csharp
public class Person {
    private string name; // hidden from outside
    public void SetName(string n) { name = n; }
    public string GetName() { return name; }
}
```

### Inheritance
Inheritance allows a class to inherit members (fields, methods) from another class. This promotes code re-use.
```csharp
public class Animal {
    public void Eat() { Console.WriteLine("Eating..."); }
}

public class Dog : Animal {
    public void Bark() { Console.WriteLine("Woof!"); }
}
```

### Polymorphism
Polymorphism lets you use a single interface or method name to represent different types or behaviours. In C#, there are two main types:

**1. Compile-time Polymorphism (Method Overloading):**
Allows multiple methods with the same name but different parameters in the same class.
```csharp
public void Attack(int dmg) { }
public void Attack(int dmg, string element) { }
```

**2. Runtime Polymorphism (Method Overriding):**
Allows derived classes to provide a specific implementation of a method that is already defined in its base class. Achieved using `virtual` and `override` keywords.
```csharp
public class Animal {
    public virtual void Speak() { Console.WriteLine("Animal sound"); }
}
public class Dog : Animal {
    public override void Speak() { Console.WriteLine("Woof!"); }
}
```
When you call `Speak()` on an `Animal` reference, the actual method executed depends on the object's runtime type:
```csharp
Animal myPet = new Dog();
myPet.Speak(); // Output: Woof!
```

### Abstraction
Abstraction means hiding complex implementation details and exposing only the essential features. It helps you focus on what an object does, not how it does it.

You achieve abstraction in C# using **interfaces** and **abstract classes**:

- **Interfaces** define a contract of what must be done, but not how.

```csharp
// Interface example
public interface IWeapon {
    void Attack();
}
public class Sword : IWeapon {
    public void Attack() { Console.WriteLine("Slash!"); }
}
```
- **Abstract classes** are classes that cannot be instantiated directly. They can contain abstract methods (without implementation) and concrete methods (with implementation). Derived classes must implement the abstract methods.

```csharp
// Abstract class example
public abstract class Shape {
    public abstract double GetArea(); // Abstract method
    public void PrintType() { Console.WriteLine("I am a shape."); } // Concrete method
}
public class Circle : Shape {
    public double Radius;
    public override double GetArea() => Math.PI * Radius * Radius;
}
```


**When to use interfaces:**
- You need multiple types of unrelated classes sharing behaviour
- Flexibility is needed
- You want dependency injection

**When to use abstract classes:**
- Classes share real functionality
- You want to avoid duplication
- You want to provide some default behaviour


## Classes, Objects, Properties and Methods

 - **Class**: A blueprint for creating objects. It defines the structure and behaviour (fields, properties, methods) that its objects will have.
    ```csharp
    public class Person {
        // ...
    }
    ```

- **Object**: An instance of a class. It represents a real entity created from the blueprint.
    ```csharp
    Person p = new Person();
    ```

 - **Properties**: Special methods that control access to fields. They allow you to get or set values, often with validation or logic.
    ```csharp
    public class Person {
        private string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }
    }
    // Usage:
    p.Name = "Alice";
    Console.WriteLine(p.Name);
    ```

 - **Methods**: Functions defined inside a class that describe the behaviours or actions the object can perform.
    ```csharp
    public class Calculator {
        public int Add(int a, int b) {
            return a + b;
        }
    }
    // Usage:
    Calculator calc = new Calculator();
    int sum = calc.Add(2, 3);
    ```

## Constructors & Object Lifecycle
Constructors are special methods that run when you create an object (i.e. an instance of a class). They are used to initialise the object's state.

### Constructor Example
```csharp
public class Person {
    public string Name;
    // Constructor
    public Person(string name) {
        Name = name;
        Console.WriteLine($"Person created: {Name}");
    }
}
// Usage:
Person p = new Person("Alice"); // Output: Person created: Alice
```

### Object Lifecycle
- **Creation:** When you use `new`, the constructor runs and memory is allocated for the object.
- **Usage:** You interact with the object using its properties and methods.
- **Destruction:** In C#, objects are destroyed automatically by the garbage collector when they are no longer referenced. You can use a destructor (finaliser) for clean-up, but it's rarely needed:
    ```csharp
    public class Person {
        ~Person() {
            // Cleanup code here
        }
    }
    ```
- **Dispose Pattern:** For objects that use unmanaged resources (like files or database connections), implement `IDisposable` and the `Dispose()` method:
    ```csharp
    public class FileHandler : IDisposable {
        public void Dispose() {
            // Release resources
        }
    }
    ```

## Inheritance vs Composition
Composition is safer and more flexible than inheritance.
Inheritance = "Dog is **an** animal"
Composition = "Car **has** an engine"

```csharp
public class Engine
{
    public void Start() { }
}

public class Car
{
    private Engine _engine = new Engine();

    public void StartCar()
    {
        _engine.Start();
    }
}
```
## SOLID Principles

The SOLID principles are five simple rules to help you write clean, maintainable, and flexible code in object-oriented programming:

1. **Single Responsibility Principle (SRP)**
    - Each class should have one job or responsibility.
    - Example: A `User` class should only handle user data, not logging or saving to a database.

2. **Open/Closed Principle (OCP)**
    - Classes should be open for extension (you can add new features), but closed for modification (existing code doesn't need to change).
    - Example: Use inheritance or interfaces so you can add new types without changing old code.

3. **Liskov Substitution Principle (LSP)**
    - Subclasses should be able to replace their base class without breaking the programme.
    - Example: If you have a `Bird` class and a `Penguin` subclass, `Penguin` should work anywhere `Bird` is expected.

4. **Interface Segregation Principle (ISP)**
    - Make small, focused interfaces instead of large, general ones.
    - Example: Instead of one big `IWorker` interface with `Work()` and `Eat()`, split into `IWorkable` and `IEatable`.

5. **Dependency Inversion Principle (DIP)**
    - Depend on abstractions (interfaces), not concrete classes. This makes code flexible and easier to test.
    - Example: Instead of a class directly creating a `FileLogger`, depend on an `ILogger` interface and pass in the logger.

### Quick Example (SRP & DIP)
```csharp
public interface ILogger {
     void Log(string message);
}
public class FileLogger : ILogger {
     public void Log(string message) { /* write to file */ }
}
public class User {
     private ILogger _logger;
     public User(ILogger logger) { _logger = logger; }
     public void Save() {
          // Save user
          _logger.Log("User saved");
     }
}
```
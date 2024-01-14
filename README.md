# Console Drawing Application

This console application simulates a drawing package supporting various drawing primitives (widgets) such as Rectangles, Squares, Ellipses, Circles, and Textboxes. The application allows widgets to be added to the drawing, specifying their location and size/shape. The key details of each widget can be printed to the console.

## Design Decisions

### SOLID Principles

The design follows SOLID principles to promote maintainability, extensibility, and testability.

1. **Single Responsibility Principle (SRP):** Each class has a single responsibility, such as the Rectangle, Square, Ellipse, Circle, and Textbox classes representing individual widgets. The DrawingAppTests class is dedicated to unit tests.

2. **Open/Closed Principle (OCP):** The application is designed to be open for extension but closed for modification. New widget types can be easily added by creating new classes that implement the IWidget interface without modifying existing code.

3. **Liskov Substitution Principle (LSP):** The IWidget interface ensures that each widget type can be substituted for another without affecting the correctness of the program.

4. **Interface Segregation Principle (ISP):** The IWidget interface only includes the necessary method Draw, ensuring that implementing classes do not need to provide unnecessary details.

5. **Dependency Inversion Principle (DIP):** High-level modules (e.g., DrawingAppTests) depend on abstractions (IWidget), and not on concrete implementations.

### Unit Testing

A suite of NUnit unit tests is included to verify the correctness of each widget's Draw method and the overall drawing output.

### Separation of Concerns

The CaptureConsoleOutput method is introduced to handle the common logic of capturing console output. This ensures cleaner and more readable test code.

## Further Work

If more time were available, the following improvements could be considered:

1. **Rendering Engine:** Implementing a rendering engine to visually display the drawing instead of just printing details to the console.

2. **User Input Handling:** Enhancing the application to accept user input for dynamically adding, modifying, or removing widgets.

3. **Graphics Library Integration:** Integrating a graphics library (e.g., System.Drawing) for a more realistic simulation of a drawing package.

4. **Serialization:** Adding support for serializing and deserializing the drawing to/from a file or database, allowing the persistence of drawings.

5. **Error Handling:** Implementing robust error handling to gracefully handle invalid inputs and potential exceptions.

6. **Dependency Injection:** Applying dependency injection to decouple dependencies and improve the overall flexibility of the application.

## How to Run

1. Clone the repository.
2. Open the solution in Visual Studio or your preferred IDE.
3. Build and run the application.

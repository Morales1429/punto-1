Console.WriteLine("Ingrese su puntuacion con coma");
double puntuacion = double.Parse(Console.ReadLine());
double bonificacion = 50000;
double total = puntuacion*bonificacion;
Console.WriteLine("Su nivel de evaluacion es "+puntuacion+" su bonificacion es "+total);
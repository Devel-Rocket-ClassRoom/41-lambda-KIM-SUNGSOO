using System;
using System.Collections.Generic;
using System.Text;


delegate void PrintMessage();

delegate int Transformer(int i);

delegate bool IsLonger(string msg, int len);

delegate void Greeting();

delegate int Calculator(int a, int b);
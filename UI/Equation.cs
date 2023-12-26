using UI.Exceptions;

namespace UI
{
    public class Equation
    {
        private List<Variable> _variables;

        private double _rightPart;

        public double RightPart { get => _rightPart; set => _rightPart = value; }
        public List<Variable> Variables { get => _variables; set => _variables = value; }

        public Equation(List<Variable> variables, double rightPart)
        {
            Variables = variables;

            RightPart = rightPart;
        }
        public static Equation GetEquation(string line)
        {

            var lineToList = line.ToLower().ToList();

            lineToList.RemoveAll(o => o == '+' || o == '=');
           
            int indexOfX = lineToList.IndexOf('x');
            int indexOfY = lineToList.IndexOf('y');
            if (indexOfX==-1)
                throw new IncorrectInputException("Отсутствует переменная X");
            if (indexOfY == -1)
                throw new IncorrectInputException("Отсутствует переменная Y");
            

            string sX = string.Empty;
            string sY = string.Empty;
            string rightPart = string.Empty;

            for (int i = 0; i < indexOfX; i++)
            {
                sX += lineToList[i];
            }
            for (int i = indexOfX + 1; i < indexOfY; i++)
            {
                sY += lineToList[i];
            }
            for (int i = indexOfY + 1; i < lineToList.Count; i++)
            {
                rightPart += lineToList[i];
            }


            switch (sX)
            {
                case "":
                    sX = "1"; break;
                case "-":
                    sX = "-1"; break;
                default: break;
            }
            switch (sY)
            {
                case "":
                    sY = "1"; break;
                case "-":
                    sY = "-1"; break;
                default: break;
            }
            var variabX = new Variable("X", double.Parse(sX));
            var variabY = new Variable("Y", double.Parse(sY));

            double RP = double.Parse(rightPart);

            return new Equation(new List<Variable>() { variabX, variabY }, RP);

        }
       
    }
}

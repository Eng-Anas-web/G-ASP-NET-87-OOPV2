namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //1 -
            //a) What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
            //A: a new copy of the object will be created on the stack, and only the new copy will be modified.

            //b)  What happens when a Customer variable is copied into another variable and one variable modifies the object
            //A: No new object is created.Both variables reference the same object in memory.Therefore, when one variable modifies the object, the changes are visible through the other variable as well.

            #endregion

            #region Question02
            //2-
            //a) Identify at least three problems with this design from an encapsulation perspective.
            //A: -The fields are public, which breaks encapsulation.
            //   -There is no validation for the data.
            //   -The struct does not use properties to control access to its data.

            //b) How can private fields and public properties improve this design?
            //A: -Private fields hide the data from direct access.
            //   -Public properties control access to the data.
            //   -Properties can validate values before storing them.
            #endregion
        }
    }
}

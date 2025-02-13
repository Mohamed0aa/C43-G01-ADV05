using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    #region interview question -_-: can i do  class with same name  ([Yes],called class overload)
    //create classes with Deffrint Genaric
    internal class note
    {
    }
    internal class note<T>
    {
    }
    internal class note<T, t>
    {
    }
    #endregion

    #region q2 
     ///i have parent class contain protected method and child inherit from it
     /// child  can  inherit it and his access modifier  become private
     
    ///if we get grand_child class  inherite from child?  [it inherit it easy] 
    ///

    //there Deffrent [ Accebility ,inhetitance => still protected]

    #endregion
}

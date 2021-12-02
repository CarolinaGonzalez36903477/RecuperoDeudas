using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class TransactionResult
    {
        private int id;
        private string error;
        private bool isOk;

        public TransactionResult()
        { }

        public int ID { get=>id; set=> id=value;}
        public string Error { get => error; set => error = value;}
        public bool isok { get => isOk; set => isOk = value;}
    }
}

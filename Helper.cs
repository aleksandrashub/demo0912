using demo0312.Context;
using demo0312.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo0312
{
    public static class Helper
    {
        public static readonly MyprojContext context = new MyprojContext();
        public static User curruser;

    }
}

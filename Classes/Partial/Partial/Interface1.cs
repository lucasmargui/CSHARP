﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interface1
{
    public interface IMinhaInterface
    {
        void Metodo1();
    }

    partial interface ITest
    {
        void Interface_Test();
    }

    partial interface ITest
    {
        void Interface_Test2();
    }

    partial struct S1
    {
        void Struct_Test() { }
    }

    partial struct S1
    {
        void Struct_Test2() { }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCS_OBJECTS
{
    public class AliquotObj
    {

        public string aliquotWorkf { get; set; }
        public string DESCRIPTION { get; set; }
        public string U_TEST_TEMPLATE_EXTENDED { get; set; }

        public AliquotObj(string p1, string p2, string p3)
        {
            // TODO: Complete member initialization
            this.aliquotWorkf = p1;
            this.DESCRIPTION = p2;
            this.U_TEST_TEMPLATE_EXTENDED = p3;
        }

        //public Aliquot()
        //{
        //    // TODO: Complete member initialization
        //}
    }
}

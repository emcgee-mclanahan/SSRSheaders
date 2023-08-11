=SWITCH​(​
   (First(Fields!Company.Value, "ShipHeadShipDtl") = "MCL" AND first(Fields!EIWOrder_c.Value, "ShipHeadShipDtl")=True), "/Images/Headers/EIWHeader.jpg",​

    First(Fields!Company.Value, "ShipHeadShipDtl") = "MCLANAI", "/Images/Headers/AnacondaHeader.jpg",​

    First(Fields!Company.Value, "ShipHeadShipDtl") = "MCLANAU", "/Images/Headers/AnacondaHeader.jpg",

    First(Fields!Company.Value, "ShipHeadShipDtl") = "MCLDFB", "/Images/Headers/DiefenbachHeader.jpg",

    First(Fields!Company.Value, "ShipHeadShipDtl") = "MCLHBH", "/Images/Headers/HBHHeader.jpg",​

    First(Fields!Company.Value, "ShipHeadShipDtl") = "MCLRBL", "/Images/Headers/RubbleCrusherHeader.jpg",​

    true,"/Images/Headers/McLanahanHeader.jpg"​

)

=SWITCH ( ​

   (First(Fields!Company.Value, "ARForm") = "MCL" AND Code.GetValue("SBU") = "EIW"), "/Images/Headers/EIWHeader.jpg", ​

​

    First(Fields!Company.Value, "ARForm") = "MCLANAI", "/Images/Headers/AnacondaHeader.jpg",​

​

    First(Fields!Company.Value, "ARForm") = "MCLANAU", "/Images/Headers/AnacondaHeader.jpg",​

​

    First(Fields!Company.Value, "ARForm") = "MCLDFB", "/Images/Headers/DiefenbachHeader.jpg",​
​

    First(Fields!Company.Value, "ARForm") = "MCLHBH", "/Images/Headers/HBHHeader.jpg", ​

​

    First(Fields!Company.Value, "ARForm") = "MCLRBL", "/Images/Headers/RubbleCrusherHeader.jpg", ​

​

    true,"/Images/Headers/McLanahanHeader.jpg" ​
​

)​

​




=SWITCH​(​
   (First(Fields!Company.Value, "ARForm") = "MCL" AND AND Code.GetValue("SBU") = "EIW"), "+1 515-243-1123",​

    true, First(Fields!PhoneNum.Value, "Company")​

)


=SWITCH​(​

    First(Fields!Company.Value, "ARForm") = "MCLUK", "enquiries@mclanahan.uk.com",​

    true,""​

)

=SWITCH​(​
   (First(Fields!Company.Value, "Company") = "MCL" AND Code.GetValue("SBU") = "EIW"), "+1 515-243-1123",​

    First(Fields!Company.Value, "Company") = "MCLANAI", "",​

    First(Fields!Company.Value, "Company") = "MCLANAU", "",

    First(Fields!Company.Value, "Company") = "MCLDFB", "",

    First(Fields!Company.Value, "Company") = "MCLHBH", "",​

    'First(Fields!Company.Value, "Company") = "MCLRBL", "",​

    true,First(Fields!PhoneNum.Value, "Company")

)

=SWITCH​(​
   (First(Fields!Company.Value, "ARForm") = "MCL" AND First(Fields!EIWOrder_c.Value, "POHeader")), "Terms And Conditions: https://www.mclanahan.com/legal-notices",​

    First(Fields!Company.Value, "ARForm") = "MCLANAI", "",​

    First(Fields!Company.Value, "ARForm") = "MCLANAU", "",

    First(Fields!Company.Value, "ARForm") = "MCLDFB", "",

    First(Fields!Company.Value, "ARForm") = "MCLHBH", "",​

    First(Fields!Company.Value, "ARForm") = "MCLRBL", "",​

    true,"Terms And Conditions: https://www.mclanahan.com/legal-notices"​

)

=SWITCH​(​

    First(Fields!Company.Value, "FSCallHd") = "MCLANAI", "/Images/Headers/AnacondaHeader.jpg",​

    First(Fields!Company.Value, "FSCallHd") = "MCLANAU", "/Images/Headers/AnacondaHeader.jpg",

    First(Fields!Company.Value, "FSCallHd") = "MCLDFB", "/Images/Headers/DiefenbachHeader.jpg",

    First(Fields!Company.Value, "FSCallHd") = "MCLHBH", "/Images/Headers/HBHHeader.jpg",​

    First(Fields!Company.Value, "FSCallHd") = "MCLRBL", "/Images/Headers/RubbleCrusherHeader.jpg",​

    true,"/Images/Headers/McLanahanHeader.jpg"​

)


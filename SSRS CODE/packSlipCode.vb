' PackSlip Code and Headers

'Image Header
=SWITCH​(​
   (First(Fields!Company.Value, "ShipHeadShipDtl") = "MCL" AND first(Fields!EIWOrder_c.Value, "ShipHeadShipDtl")=True), "/Images/Headers/EIWHeader.jpg",​

    First(Fields!Company.Value, "ShipHeadShipDtl") = "MCLANAI", "/Images/Headers/AnacondaHeader.jpg",​

    First(Fields!Company.Value, "ShipHeadShipDtl") = "MCLANAU", "/Images/Headers/AnacondaHeader.jpg",

    First(Fields!Company.Value, "ShipHeadShipDtl") = "MCLDFB", "/Images/Headers/DiefenbachHeader.jpg",

    First(Fields!Company.Value, "ShipHeadShipDtl") = "MCLHBH", "/Images/Headers/HBHHeader.jpg",​

    First(Fields!Company.Value, "ShipHeadShipDtl") = "MCLRBL", "/Images/Headers/RubbleCrusherHeader.jpg",​

    true,"/Images/Headers/McLanahanHeader.jpg"​

)
'Address

'Phone
=SWITCH​(​
   (First(Fields!Company.Value, "ShipHeadShipDtl") = "MCL" AND First(Fields!EIWOrder_c.Value, "ShipHeadShipDtl")=True), "+1 515-243-1123",​

    true, First(Fields!PhoneNum.Value, "Company")​

)
'Fax
=SWITCH​(​
   (First(Fields!Company.Value, "ShipHeadShipDtl") = "MCL" AND First(Fields!EIWOrder_c.Value, "ShipHeadShipDtl")=True), "+1 515-243-8214",​

    true, First(Fields!FaxNum.Value, "Company")​

)
'Email
=SWITCH​(​

    First(Fields!Company.Value, "ShipHeadShipDtl") = "MCLUK", "enquiries@mclanahan.uk.com",​

    true,""​

)
'Legal
' RMA Form Header And Code
'Image Header
=SWITCH​(​
   (First(Fields!Company.Value, "dsRMA") = "MCL" AND first(Fields!EIWOrder_c.Value, "dsRMA")=True), "/Images/Headers/EIWHeader.jpg",​

    First(Fields!Company.Value, "dsRMA") = "MCLANAI", "/Images/Headers/AnacondaHeader.jpg",​

    First(Fields!Company.Value, "dsRMA") = "MCLANAU", "/Images/Headers/AnacondaHeader.jpg",

    First(Fields!Company.Value, "dsRMA") = "MCLDFB", "/Images/Headers/DiefenbachHeader.jpg",

    First(Fields!Company.Value, "dsRMA") = "MCLHBH", "/Images/Headers/HBHHeader.jpg",​

    First(Fields!Company.Value, "dsRMA") = "MCLRBL", "/Images/Headers/RubbleCrusherHeader.jpg",​

    true,"/Images/Headers/McLanahanHeader.jpg"​

)

'phone
=SWITCH​(​
   (First(Fields!Company.Value, "dsRMA") = "MCL" AND First(Fields!EIWOrder_c.Value, "dsRMA")=True), "+1 515-243-1123",​

    true, First(Fields!PhoneNum.Value, "dsCompany")
)
'fax
=iif(First(Fields!EIWOrder_c.Value, "dsRMA"), "+1 515-243-8214", First(Fields!FaxNum.Value, "dsCompany"))
'email
=SWITCH​(​

    First(Fields!Company.Value, "dsRMA") = "MCLUK", "enquiries@mclanahan.uk.com",​

    true,""​

)

=SWITCH​(​
   (First(Fields!Company.Value, "dsRMA") = "MCL"AND First(Fields!EIWOrder_c.Value, "dsRMA")=true, "+1 515-243-1123"),​

    true, First(Fields!PhoneNum.Value, "dsCompany")​

)
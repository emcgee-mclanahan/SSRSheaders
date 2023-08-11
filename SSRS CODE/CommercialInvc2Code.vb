' Commerical invoice 2 document code changes

'header
=SWITCH​(​
   (First(Fields!Company.Value, "Company") = "MCL" AND first(Fields!EIWOrder_c.Value, "OrderHed")=True), "/Images/Headers/EIWHeader.jpg",​

    First(Fields!Company.Value, "Company") = "MCLANAI", "/Images/Headers/AnacondaHeader.jpg",​

    First(Fields!Company.Value, "Company") = "MCLANAU", "/Images/Headers/AnacondaHeader.jpg",

    First(Fields!Company.Value, "Company") = "MCLDFB", "/Images/Headers/DiefenbachHeader.jpg",

    First(Fields!Company.Value, "Company") = "MCLHBH", "/Images/Headers/HBHHeader.jpg",​

    First(Fields!Company.Value, "Company") = "MCLRBL", "/Images/Headers/RubbleCrusherHeader.jpg",​

    true,"/Images/Headers/McLanahanHeader.jpg"​

)
'address
=iif(

First(Fields!EIWOrder_c.Value, "OrderHed"),

"Eagle Iron Works" & vbcrlf & "129 E Holcomb Avenue" & vbcrlf & "Des Moines, Iowa 50313" & vbcrlf & "United States",

trim(split(First(Fields!Calc_CompanyAddressList.Value, "OrderHed"),"~")(0)) & vbcrlf & 
trim(split(First(Fields!Calc_CompanyAddressList.Value, "OrderHed"),"~")(1)) & vbcrlf & 
trim(split(First(Fields!Calc_CompanyAddressList.Value, "OrderHed"),"~")(2)) & vbcrlf & 
trim(split(First(Fields!Calc_CompanyAddressList.Value, "OrderHed"),"~")(3)) & vbcrlf & 
trim(split(First(Fields!Calc_CompanyAddressList.Value, "OrderHed"),"~")(4)) & vbcrlf & 
trim(split(First(Fields!Calc_CompanyAddressList.Value, "OrderHed"),"~")(5)) & vbcrlf & 
trim(split(First(Fields!Calc_CompanyAddressList.Value, "OrderHed"),"~")(6)) & vbcrlf & 
trim(split(First(Fields!Calc_CompanyAddressList.Value, "OrderHed"),"~")(7))

)
'phone
=SWITCH​(​
   (First(Fields!Company.Value, "Company") = "MCL" AND First(Fields!EIWOrder_c.Value, "OrderHed")=True), "+1 515-243-1123",​

    true, First(Fields!PhoneNum.Value, "Company")​

)

'fax
=SWITCH​(​
   (First(Fields!Company.Value, "Company") = "MCL" AND First(Fields!EIWOrder_c.Value, "OrderHed")=True), "+1 515-243-8214",​

    true, First(Fields!FaxNum.Value, "Company")​

)
' legal 
=SWITCH​(​
   (First(Fields!Company.Value, "Company") = "MCL" AND First(Fields!EIWOrder_c.Value, "OrderHed")), "https://www.mclanahan.com/legal-notices",​

    First(Fields!Company.Value, "Company") = "MCLANAI", "",​

    First(Fields!Company.Value, "Company") = "MCLANAU", "",

    First(Fields!Company.Value, "Company") = "MCLDFB", "",

    First(Fields!Company.Value, "Company") = "MCLHBH", "",​

    First(Fields!Company.Value, "Company") = "MCLRBL", "",​

    true,"https://www.mclanahan.com/legal-notices"​

)

' PO FORM Header Changes & Code Blocks

=SWITCH​(​
   (First(Fields!Company.Value, "POHeader") = "MCL" AND first(Fields!EIWOrder_c.Value, "POHeader")=True), "/Images/Headers/EIWHeader.jpg",​

    First(Fields!Company.Value, "POHeader") = "MCLANAI", "/Images/Headers/AnacondaHeader.jpg",​

    First(Fields!Company.Value, "POHeader") = "MCLANAU", "/Images/Headers/AnacondaHeader.jpg",

    First(Fields!Company.Value, "POHeader") = "MCLDFB", "/Images/Headers/DiefenbachHeader.jpg",

    First(Fields!Company.Value, "POHeader") = "MCLHBH", "/Images/Headers/HBHHeader.jpg",​

    First(Fields!Company.Value, "POHeader") = "MCLRBL", "/Images/Headers/RubbleCrusherHeader.jpg",​

    true,"/Images/Headers/McLanahanHeader.jpg"​

)

' address
=iif(

First(Fields!EIWOrder_c.Value, "POHeader"),

"Eagle Iron Works, LLC" & vbcrlf & "129 E Holcomb Avenue" & vbcrlf & "Des Moines, Iowa 50313" & vbcrlf & "United States",

trim(split(First(Fields!Calc_AddressList.Value, "Company"),"~")(0)) & vbcrlf & 
trim(split(First(Fields!Calc_AddressList.Value, "Company"),"~")(1)) & vbcrlf & 
trim(split(First(Fields!Calc_AddressList.Value, "Company"),"~")(2)) & vbcrlf & 
trim(split(First(Fields!Calc_AddressList.Value, "Company"),"~")(3)) & vbcrlf & 
trim(split(First(Fields!Calc_AddressList.Value, "Company"),"~")(4)) & vbcrlf & 
trim(split(First(Fields!Calc_AddressList.Value, "Company"),"~")(5)) & vbcrlf & 
trim(split(First(Fields!Calc_AddressList.Value, "Company"),"~")(6)) & vbcrlf & 
trim(split(First(Fields!Calc_AddressList.Value, "Company"),"~")(7))

)

=SWITCH​(​
   (First(Fields!Company.Value, "POHeader") = "MCL" AND First(Fields!EIWOrder_c.Value, "POHeader")=True), "+1 515-243-1123",​

    true, First(Fields!PhoneNum.Value, "Company")
)
' Hide fax for UK
=SWITCH​(​
   (First(Fields!Company.Value, "POHeader") = "MCL" AND First(Fields!EIWOrder_c.Value, "POHeader")=True), "+1 515-243-8214",​

    true, First(Fields!FaxNum.Value, "Company")​

)
' Ensure the hidden field is set for Email for all except UK 
=SWITCH​(​

    First(Fields!Company.Value, "POHeader") = "MCLUK", "enquiries@mclanahan.uk.com",​

    true,""​

)

=SWITCH​(​
   (First(Fields!Company.Value, "POHeader") = "MCL" AND First(Fields!EIWOrder_c.Value, "POHeader")), "https://www.mclanahan.com/legal-notices",​

    First(Fields!Company.Value, "POHeader") = "MCLANAI", "",​

    First(Fields!Company.Value, "POHeader") = "MCLANAU", "",

    First(Fields!Company.Value, "POHeader") = "MCLDFB", "",

    First(Fields!Company.Value, "POHeader") = "MCLHBH", "",​

    First(Fields!Company.Value, "POHeader") = "MCLRBL", "",​

    true,"https://www.mclanahan.com/legal-notices"​

)
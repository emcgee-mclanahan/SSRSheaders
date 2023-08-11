' AR Invoice Form Code | This form needs GetCode.Value Changed to SBU & SalesBusUnit added to data def | Includes ARForm Long Desc
'Code.GetValue()
=Code.SetValue("SBU", Fields!SalesBusUnit_c.Value)
' Header
=SWITCH ( ​

   (First(Fields!Company.Value, "ARForm") = "MCL" AND Code.GetValue("SBU") = "EIW"), "/Images/Headers/EIWHeader.jpg", ​
    First(Fields!Company.Value, "ARForm") = "MCLANAI", "/Images/Headers/AnacondaHeader.jpg",​
    First(Fields!Company.Value, "ARForm") = "MCLANAU", "/Images/Headers/AnacondaHeader.jpg",​
    First(Fields!Company.Value, "ARForm") = "MCLDFB", "/Images/Headers/DiefenbachHeader.jpg",​
    First(Fields!Company.Value, "ARForm") = "MCLHBH", "/Images/Headers/HBHHeader.jpg", ​
    First(Fields!Company.Value, "ARForm") = "MCLRBL", "/Images/Headers/RubbleCrusherHeader.jpg", ​
    true,"/Images/Headers/McLanahanHeader.jpg" ​
​

)
'Address
=iif(

    Code.GetValue("SBU")="EIW", 

    "Eagle Iron Works" & vbcrlf & "129 E Holcomb Avenue" & vbcrlf & "Des Moines, Iowa 50313" & vbcrlf & "United States", 

    trim(split(First(Fields!Calc_CompanyAddressList.Value, "ARForm"), "~")(0)) & vbcrlf & 
    trim(split(First(Fields!Calc_CompanyAddressList.Value, "ARForm"), "~")(1)) & vbcrlf & 
    trim(split(First(Fields!Calc_CompanyAddressList.Value, "ARForm"), "~")(2)) & vbcrlf & 
    trim(split(First(Fields!Calc_CompanyAddressList.Value, "ARForm"), "~")(3)) & vbcrlf & 
    trim(split(First(Fields!Calc_CompanyAddressList.Value, "ARForm"), "~")(4)) & vbcrlf & 
    trim(split(First(Fields!Calc_CompanyAddressList.Value, "ARForm"), "~")(5)) & vbcrlf & 
    trim(split(First(Fields!Calc_CompanyAddressList.Value, "ARForm"), "~")(6)) & vbcrlf & 
    trim(split(First(Fields!Calc_CompanyAddressList.Value, "ARForm"), "~")(7))
)
'TaxID
=Switch(
    First(Fields!Company.Value, "ARForm") = "MCLAUS", "ABN " & First(Fields!StateTaxID.Value, "Company"),
    TRUE, ""
)
'Phone
=SWITCH​(​(First(Fields!Company.Value, "ARForm") = "MCL" AND Code.GetValue("SBU") = "EIW"), "+1 515-243-1123",​
    true, First(Fields!PhoneNum.Value, "Company")​
)
'Fax
=SWITCH​(​
   (First(Fields!Company.Value, "ARForm") = "MCL" AND Code.GetValue("SBU") = "EIW"), "+1 515-243-8214",​

    true, First(Fields!FaxNum.Value, "Company")​

)
'Legal
=SWITCH​(​
   (First(Fields!Company.Value, "ARForm") = "MCL" AND Code.GetValue("SBU") = "EIW"), "Terms And Conditions: https://www.mclanahan.com/legal-notices",​

    First(Fields!Company.Value, "ARForm") = "MCLANAI", "",​

    First(Fields!Company.Value, "ARForm") = "MCLANAU", "",

    First(Fields!Company.Value, "ARForm") = "MCLDFB", "",

    First(Fields!Company.Value, "ARForm") = "MCLHBH", "",​

    First(Fields!Company.Value, "ARForm") = "MCLRBL", "",​

    true,"Terms And Conditions: https://www.mclanahan.com/legal-notices"​

)
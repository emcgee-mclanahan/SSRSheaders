' Cust St
=Code.SetValue("SBU", Fields!SalesBusUnit_c.Value)
'Header
=SWITCH ( ​

   (First(Fields!Company.Value, "Company") = "MCL" AND Code.GetValue("SBU") = "EIW"), "/Images/Headers/EIWHeader.jpg", ​
    First(Fields!Company.Value, "Company") = "MCLANAI", "/Images/Headers/AnacondaHeader.jpg",​
    First(Fields!Company.Value, "Company") = "MCLANAU", "/Images/Headers/AnacondaHeader.jpg",​
    First(Fields!Company.Value, "Company") = "MCLDFB", "/Images/Headers/DiefenbachHeader.jpg",​
    First(Fields!Company.Value, "Company") = "MCLHBH", "/Images/Headers/HBHHeader.jpg", ​
    First(Fields!Company.Value, "Company") = "MCLRBL", "/Images/Headers/RubbleCrusherHeader.jpg", ​
    true,"/Images/Headers/McLanahanHeader.jpg" 
​

)
'address
=iif(

    Code.GetValue("SBU")="EIW", 

    "Eagle Iron Works" & vbcrlf & "129 E Holcomb Avenue" & vbcrlf & "Des Moines, Iowa 50313" & vbcrlf & "United States", 

    trim(split(First(Fields!Calc_CompanyAddressList.Value, "Customer_InvcHead_CashDtl_RptLabel"), "~")(0)) & vbcrlf & 
    trim(split(First(Fields!Calc_CompanyAddressList.Value, "Customer_InvcHead_CashDtl_RptLabel"), "~")(1)) & vbcrlf & 
    trim(split(First(Fields!Calc_CompanyAddressList.Value, "Customer_InvcHead_CashDtl_RptLabel"), "~")(2)) & vbcrlf & 
    trim(split(First(Fields!Calc_CompanyAddressList.Value, "Customer_InvcHead_CashDtl_RptLabel"), "~")(3)) & vbcrlf & 
    trim(split(First(Fields!Calc_CompanyAddressList.Value, "Customer_InvcHead_CashDtl_RptLabel"), "~")(4)) & vbcrlf & 
    trim(split(First(Fields!Calc_CompanyAddressList.Value, "Customer_InvcHead_CashDtl_RptLabel"), "~")(5)) & vbcrlf & 
    trim(split(First(Fields!Calc_CompanyAddressList.Value, "Customer_InvcHead_CashDtl_RptLabel"), "~")(6)) & vbcrlf & 
    trim(split(First(Fields!Calc_CompanyAddressList.Value, "Customer_InvcHead_CashDtl_RptLabel"), "~")(7))
)

'phne
=SWITCH​(​(First(Fields!Company.Value, "Company") = "MCL" AND Code.GetValue("SBU") = "EIW"), "+1 515-243-1123",​
    true, First(Fields!PhoneNum.Value, "Company")​
)

'fax
=SWITCH​(​
   (First(Fields!Company.Value, "Company") = "MCL" AND Code.GetValue("SBU") = "EIW"), "+1 515-243-8214",​

    true, First(Fields!FaxNum.Value, "Company")​

)

'abu
=Switch(
    First(Fields!Company.Value, "Customer_InvcHead_CashDtl_RptLabel") = "MCLAUS", "ABN " & First(Fields!StateTaxID.Value, "Company"),
    TRUE, ""
)
'legal
=SWITCH​(​
   (First(Fields!Company.Value, "Company") = "MCL" AND Code.GetValue("SBU") = "EIW"), "Terms And Conditions: https://www.mclanahan.com/legal-notices",​

    First(Fields!Company.Value, "Company") = "MCLANAI", "",​

    First(Fields!Company.Value, "Company") = "MCLANAU", "",

    First(Fields!Company.Value, "Company") = "MCLDFB", "",

    First(Fields!Company.Value, "Company") = "MCLHBH", "",​

    First(Fields!Company.Value, "Company") = "MCLRBL", "",​

    true,"Terms And Conditions: https://www.mclanahan.com/legal-notices"​

)
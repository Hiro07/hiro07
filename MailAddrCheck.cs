{\rtf1\ansi\ansicpg1252\cocoartf1038\cocoasubrtf360
{\fonttbl\f0\fnil\fcharset0 Consolas;\f1\fnil\fcharset128 HiraKakuProN-W3;\f2\fnil\fcharset0 Consolas-Bold;
}
{\colortbl;\red255\green255\blue255;\red109\green109\blue109;\red255\green255\blue255;\red26\green26\blue26;
\red18\green80\blue140;\red0\green0\blue255;\red27\green115\blue0;}
\paperw11900\paperh16840\margl1440\margr1440\vieww9000\viewh8400\viewkind0
\deftab720
\pard\pardeftab720\sl280

\f0\fs26 \cf2 \cb3 /// \cf4 \
\cf2 /// 
\f1 \'95\'b6\'8e\'9a\'97\'f1\'82\'aa\'83\'81\'81\'5b\'83\'8b\'83\'41\'83\'68\'83\'8c\'83\'58\'82\'c6\'82\'b5\'82\'c4\'90\'b3\'82\'b5\'82\'a2\'82\'a9\'94\'bb\'92\'e8
\f0  (
\f1 \'90\'b3\'8b\'4b\'95\'5c\'8c\'bb\'82\'f0\'8e\'67\'97\'70
\f0 )
\f1 \'81\'69
\f0 RFC
\f1 \'82\'c9\'82\'cd\'8f\'80\'8b\'92\'82\'b5\'82\'c4\'82\'a2\'82\'dc\'82\'b9\'82\'f1\'81\'6a
\f0 \'a0\cf4 \
\cf2 /// easy way to validate a string if the string looks like a mail address string ( this is not valid with strict RFC, but useful or following almost 80% types of mail addresses in use i think;) )\'a0\cf4 \
\cf2 ///\'a0 i used regular expression, of course ;)\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf4 \
\cf2 /// 
\f1 \'88\'c8\'89\'ba\'82\'cc\'8c\'60\'8e\'ae\'82\'c9\'91\'ce\'89\'9e\'82\'b5\'82\'dc\'82\'b7\'81\'42
\f0 \'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf4 \
\cf2 /// this function checks these types of mail addr below\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf4 \
\cf2 /// 1. user123@example456.co.jp 
\f1 \'83\'81\'81\'5b\'83\'8b\'83\'41\'83\'68\'83\'8c\'83\'58\'82\'cc\'82\'dd\'82\'cc\'8c\'60\'8e\'ae
\f0  ( mail addr only)\'a0\cf4 \
\cf2 /// 2. hoge 
\f1 \'83\'7a\'83\'51
\f0 \'a0 
\f1 \'83\'86\'81\'5b\'83\'55\'96\'bc\'81\'7b
\f0 <
\f1 \'83\'81\'81\'5b\'83\'8b\'83\'41\'83\'68\'83\'8c\'83\'58
\f0 > 
\f1 \'8c\'60\'8e\'ae
\f0  ( name + )\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf4 \
\cf2 ///\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf4 \
\cf2 /// \cf4 \
\cf2 ///\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf4 \
\pard\pardeftab720\sl280

\f2\b \cf5 public
\f0\b0 \cf4  
\f2\b \cf5 static
\f0\b0 \cf4  
\f2\b \cf5 bool
\f0\b0 \cf4  \cf0 IsValidMailAddrString(
\f2\b \cf5 string
\f0\b0 \cf4  \cf0 mailAddrStr) \cf4 \
\pard\pardeftab720\sl280
\cf0 \{\cf4 \
\'a0\'a0\'a0\'a0
\f2\b \cf5 if
\f0\b0 \cf4  \cf0 (mailAddrStr.Contains(\cf6 "<"\cf0 )) \{\cf4 \
\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\cf7 // name + <mail addr>;\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf4 \
\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\cf7 //\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf4 \
\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\cf7 // 
\f1 \'90\'b3\'8b\'4b\'95\'5c\'8c\'bb\'82\'f0\'90\'dd\'92\'e8\'81\'42\'8f\'da\'8d\'d7\'82\'cd\'90\'b3\'8b\'4b\'95\'5c\'8c\'bb\'82\'f0\'8c\'a9\'82\'c4\'82\'cb
\f0 ^^\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf4 \
\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0
\f2\b \cf5 string
\f0\b0 \cf4  \cf0 regPattern = \cf6 @"^\\s*[^<]*\\s*[<]\\s*[^@\\s]+[@]([^.\\s]+[.])\{1,\}[^.\\s]+\\s*[>]\\s*$"\cf0 ;\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf4 \
\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0
\f2\b \cf5 return
\f0\b0 \cf4  \cf0 System.Text.RegularExpressions.Regex.IsMatch(mailAddrStr, regPattern);\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf4 \
\'a0\'a0\'a0\'a0\'a0\cf0 \}\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf4 \
\'a0\'a0\'a0\'a0\'a0
\f2\b \cf5 else
\f0\b0 \cf4 \
\'a0\'a0\'a0\'a0\'a0\cf0 \{\cf4 \
\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\cf7 // mail addr only\cf4 \
\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\cf7 // user@example.co.jp\cf4 \
\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0
\f2\b \cf5 string
\f0\b0 \cf4  \cf0 regPattern = \cf6 @"^[^@\\s]+[@]([^.\\s]+[.])\{1,\}[^.\\s]+\\s*$"\cf0 ;\cf4 \
\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0
\f2\b \cf5 return
\f0\b0 \cf4  \cf0 System.Text.RegularExpressions.Regex.IsMatch(mailAddrStr, regPattern);\cf4 \
\'a0\'a0\'a0\'a0\'a0\cf0 \}\cf4 \
\cf0 \}\cf4 \
\'a0\
\'a0\
\pard\pardeftab720\sl280
\cf2 ///\cf4 \
\cf2 /// 
\f1 \'82\'b1\'82\'cc\'8a\'d6\'90\'94\'82\'f0\'8e\'67\'82\'a4\'8f\'ea\'8d\'87\'82\'cd\'88\'c8\'89\'ba\'82\'cc\'82\'e6\'82\'a4\'82\'c9\'82\'a0\'82\'e9\'92\'f6\'93\'78\'8b\'96\'97\'65\'90\'ab\'82\'f0\'8e\'9d\'82\'bd\'82\'b9\'82\'c4\'82\'ad\'82\'be\'82\'b3\'82\'a2\'82\'cb\'81\'42
\f0 \cf4 \
\cf2 /// Please use this function as like below. because this func couldnt follow all types of mail addrs in RFC\cf4 \
\cf2 ///\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf4 \
\pard\pardeftab720\sl280
\cf7 // execute click event of TextBox named "txtMailText"\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf4 \
\pard\pardeftab720\sl280

\f2\b \cf5 private
\f0\b0 \cf4  
\f2\b \cf5 void
\f0\b0 \cf4  \cf0 txtMailText_Validating(
\f2\b \cf5 object
\f0\b0 \cf4  \cf0 sender, CancelEventArgs e)\'a0\'a0\'a0\'a0\'a0\'a0\'a0 \cf4 \
\pard\pardeftab720\sl280
\cf0 \{\cf4 \
\'a0\'a0\'a0\'a0\cf7 // text box ?\cf4 \
\'a0\'a0\'a0\'a0\cf0 TextBox tb;\cf4 \
\'a0\'a0\'a0\'a0
\f2\b \cf5 if
\f0\b0 \cf4  \cf0 (sender.GetType() == 
\f2\b \cf5 typeof
\f0\b0 \cf0 (TextBox))\cf4 \
\'a0\'a0\'a0\'a0\cf0 \{\cf4 \
\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\cf0 tb = (TextBox)sender;\cf4 \
\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0
\f2\b \cf5 if
\f0\b0 \cf4  \cf0 (tb.Text == \cf6 ""\cf0 ) 
\f2\b \cf5 return
\f0\b0 \cf0 ;\cf4 \
\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\cf7 // ignore empty string\cf4 \
\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0
\f2\b \cf5 if
\f0\b0 \cf4  \cf0 (!IsValidMailAddrString(tb.Text))\cf4 \
\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\cf0 \{\cf4 \
\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\cf7 // if it doesnt look like mail addr\cf4 \
\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0
\f2\b \cf5 if
\f0\b0 \cf4  \cf0 (MessageBox.Show(\cf6 "It doesn't seem like a mail address string.\\r\\n\\r\\nAre you sure you want to put this text as a mail address?"\cf0 , \cf6 "Mail Address Validation"\cf0 , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)\cf4 \
\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\cf0 \{\cf4 \
\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\cf0 e.Cancel = 
\f2\b \cf5 true
\f0\b0 \cf0 ;\cf4 \
\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\cf0 \}\cf4 \
\'a0\'a0\'a0\'a0\'a0\'a0\'a0\'a0\cf0 \}\cf4 \
\'a0\'a0\'a0\'a0\cf0 \}\cf4 \
\cf0 \}\cf4 \
}
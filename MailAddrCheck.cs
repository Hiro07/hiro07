/// 
/// 文字列がメールアドレスとして正しいか判定 (正規表現を使用)（RFCには準拠していません） 
/// easy way to validate a string if the string looks like a mail address string ( this is not valid with strict RFC, but useful or following almost 80% types of mail addresses in use i think;) ) 
///  i used regular expression, of course ;)        
/// 以下の形式に対応します。        
/// this function checks these types of mail addr below        
/// 1. user123@example456.co.jp メールアドレスのみの形式 ( mail addr only) 
/// 2. hoge ホゲ  ユーザ名＋<メールアドレス> 形式 ( name + )        
///         
/// 
///         
public static bool IsValidMailAddrString(string mailAddrStr) 
{
    if (mailAddrStr.Contains("<")) {
         // name + <mail addr>;                
         //                      
         // 正規表現を設定。詳細は正規表現を見てね^^                
         string regPattern = @"^\s*[^<]*\s*[<]\s*[^@\s]+[@]([^.\s]+[.]){1,}[^.\s]+\s*[>]\s*$";                
         return System.Text.RegularExpressions.Regex.IsMatch(mailAddrStr, regPattern);            
     }            
     else
     {
        // mail addr only
        // user@example.co.jp
        string regPattern = @"^[^@\s]+[@]([^.\s]+[.]){1,}[^.\s]+\s*$";
        return System.Text.RegularExpressions.Regex.IsMatch(mailAddrStr, regPattern);
     }
}
 
 
///
/// この関数を使う場合は以下のようにある程度許容性を持たせてくださいね。
/// Please use this function as like below. because this func couldnt follow all types of mail addrs in RFC
///        
// execute click event of TextBox named "txtMailText"        
private void txtMailText_Validating(object sender, CancelEventArgs e)        
{
    // text box ?
    TextBox tb;
    if (sender.GetType() == typeof(TextBox))
    {
        tb = (TextBox)sender;
        if (tb.Text == "") return;
        // ignore empty string
        if (!IsValidMailAddrString(tb.Text))
        {
            // if it doesnt look like mail addr
            if (MessageBox.Show("It doesn't seem like a mail address string.\r\n\r\nAre you sure you want to put this text as a mail address?", "Mail Address Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

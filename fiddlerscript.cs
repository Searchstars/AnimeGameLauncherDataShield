import System;

import System.Windows.Forms;
import Fiddler;
import System.Text.RegularExpressions;

var list = [
    "https://log-upload.mihoyo.com",
    ];
var host_list = [
    "log-upload.mihoyo.com",
    "log-upload-os.mihoyo.com:443",
    ];

public class Handlers
{
    static function OnBeforeRequest(oS: Session) {
        var active = 10 // Debugging
        if(active){
            if(oS.uriContains("http://overseauspider.yuanshen.com:8888/log")){
                oS.oRequest.FailSession(404, "Blocked", "yourmom"); // How funny
            }
            
            for(var i = 0;i<81;i++) {
                if(oS.uriContains(list[i])) {
                    // Console.WriteLine(oS.fullUrl);;
                    oS.host = "localhost";
                    // oS.host = "localhost:22223";
                    break;
                }
                
        }
    }

}
                            
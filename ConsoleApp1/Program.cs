// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CS_Using_HashSet
{
    class Program
    {
        static string[] namesLarge = new string[] {
        "QyOJA1","gqDSoa","A1S6TS","MC3$m$","k%#GKj","CpFx7Q","qu8c9K","UzaGvv","ZSgCeR","CxH4QH","T5Wm2n","qcvRm8","&XKKPP","&+8H!h","X@v2QE","Xmuyaz","Xh&q*7","tJHF&4","ajrSSx","Ym!YBs","U9yHOB","V5a3zs","b4=Baj","KujvrN","CCX6uo","V12OS7","Xmphy&","O$M!cF","&hNJyB","fS%dC=","Tzu40#","72FM#w","zFnj5r","vh3cpK","+@uNkM","6Zgq1!","pGz+t#","r0kxuJ","FZ=fa8","hOT8m*","q=jTzJ","GaUR@!","Pd&hT3","ScpPrT","#@8kV=","uBAcw5","C4a45n","f#nbbM","dBnKHb","ePaFB6","Cgs*@S","0kpEDa","g*nUWe","=zv43n","3hQBtT","3PBnVY","FuxdRN","7cqOrb","aM3PMF","z&BV!j","O2pxo4","KB8=Oq","U6zY*A","q@5uE9","C%cy0@","@enQCW","N9Mr2#","X8Qy&a","zTJa$r","3B$&2u","son6nq","aET@cO","+Y+XW1","gNB754","C8TvdV","RFY059","SZpZ7s","0A#FuC","%kGxPD","fZZj&t","&8t+jr","DKAfwG","oHXdv$","nKXPCz","c3p*@+","$R1$H3","#OVEZW","MGdz!V","dmu=gP","9hb=td","DUVa8q","HUJ&Ys","v*kWg0","daNSMt","0Xn%*m","kKyhY3","51nCy7","b1EuCa","arNUy7","N87yj5","76RKM3","v!zrZf","SPRz%D","SxYC@f","xMyb9f","YV5cAn","w1n%Rj","foeGzg","!E8fBG","J54z+h","jrkH*b","X9=2mk","GG36Y3","uac*ur","a@jBVt","53%9Cs","W83QMv","*8QyCC","eQe&g9","ppppq&","XV5FfR","Rq1qxX","3n6unf","j+1PBm","Sj5CR#","qMAtH!","ZykHFu","800VSp","X81E@+","*@hb&9","TrA#qj","AjJz+b","DP15ef","=jAP0n","pc7x32","rYbEch","dyw00J","2=n1uA","NvtB3k","G5Q&%o","NXTa4U","Zu4j=x","92TD%f","hy!GHd","qVvumO","fA4u0k","6vvSJ$","Jet#7r","pKpfbB","4db5th","6#z5$P","uEFRGP","8UcqZ4","T3&215","MePv!@","utbQXF","PTbHxW","5D1Z#1","sb4PbG","*e9h5Y","n1v2dS","do$rP7","4f+c%V","E*4bWJ","nKKADZ","0b%Y%H","m$Cgad","rAW8vq","4DN$NW","4Bo7Nz","u5CkeS","PghokB","En9cRQ","wxks6X","reysdb","!c@%YK","YcYC@h","qumunC","j$&dxC","UAURzO","PUefaH","E21Nc#","Db0%BV","pKuoW9","mUEDx%","rh$g11","0yJQeu","EbGZ8j","Mt4qdV","$Co0hS","cS86#4","Udc3Xv","paBDgD","h#KMQ1","zrN89o","pqnnqs","14Q5k7","d%eq*W","1*jFX+","aFNReG","yHT4Qc","kbBraq","=5Sdq0","nZC=a6","NZWr!f","&shumf","177Kbm","cptmfe","s$Mu=r","%ta9AW","$zx1m+","rHxEkm","Pw#0aU","w0*7$5","%a86z6","s6#SM2","rHFuS=","g%3wWw","V&Cqa*","#+&AqE","W9HSog","ToXBXW","Mv9EGR","sAg*qk","R8Afj&","=YSaXy","fxs1oc","EEEDvW","Hj2JPJ","RYx7Z2","vrgP%5","9wJ#sb","#3kuZ*","rsFgRO","stwk@1","RD*a&Q","JcOT*n","eK31Qa","xquNH5","@+=geo","Z1a3n1","2x=nKq","*+%N+r","dx@qhe","twsppo","W1xR0Q","!X@7!G","OVo@xR","%Rna!e","mGpvnj","Wj@FKb","%DRb$*","%#pcj7","e7s5@B","QDSeE5","ST&3Db","A*qxXZ","kk371j","#kPWQR","Z97gpz","3!QYXe","TeWjjb","5kWjHB","mV=NjC","jNAqab","7&DmwS","Cq9+mT","O2UpDf","y1Bugn","b0EmXa","QoeZaA","YWD82k","TzCKJK","1THYhY","!NFNKk","=6cZVd","GsQcxw","KG68kj","UrE5H6","3mu+Nf","T7KMW#","ZMx4A*","vsj!yp","x%kYa2","Y*dUJG","mBcyma","U3OfRR","2c498$","ukS8#x","eN2oF4","Ns8y%F","+TW@9Z","Odm6pW","%#Z0q7","Hhu#0$","ySa2tY","UqS%VP","g&wmj0","AtABk@","cGYbxU","jvF0=1","tyUgkv","YsHadE","%JZj$C","6B81SQ","pjM@q*","bF+wXY","*Tjegk","wey@fT","v$q1JA","Qu3gKN","v*M439","3JN7O!","sUFjgP","SU4Y*4","xzUEqr","aqWC!P","R!e9!x","uoUApj","tm5@&7","FjvJnx","JYFMJU","+=Hd#A","jTPC18","03v1R4","yBhS&o","++zn*F","e3G30u","=8ORsX","Ku+fKq","WwD0+Q","DAfVf9","HYTvx6","hR+N0H","nbT3#j","wa$8r2","Ns16PK","fmDUZX","T9hJ94","p$wUMo","MrPQ*w","73uQcJ","EWTe4g","w9Efq4","v@#nS6","VEt0+3","B7txn3","uAp#ty","PEssuj","U7O20k","=Z!Yr2","&AtjkE","263baN","+2nBb!","&B8RVC","p*QFUn","5gjFhk","rU$jVT","FU&Ob&","mj+Zzb","SdNax3","2v9ORf","QvQBZ2","BTPoMF","t!V0Qx","u1ocvS","B!eJaE","S=Sq!w","urXgvw","4=A%o9","hE7tPJ","KXgkJ5","En14r0","G%zwkr","5x$xnX","=1@R52","Hz7DN7","Qa#co*","+0KrTb","jfttsZ","foajmK","0PnzZ#","hnomy=","$h2b%B","Df@*Tf","z+BRoC","2!&GFR","++Cs96","YbQnwA","oEHt8&","YtOn3X","of=9Zf","+fh2FD","Vp!Qje","fMHQju","4ERopj","YPU@xu","07#wY5","bGbjR8","r1p*RY","sCvZxg","FQj7O$","ov1nmy","q!K87+","yCvVkR","g8BASP","NQ0kbC","c$4o%o","jEAz+w","=K0cOv","nc%=Sq","Mom6Hr","T3zPuH","DWtvjV","1+wVYC","9@JXp#","@sJXa5","hDVD5O","Y$2tH+","=aM#!V","2MnF*M","3T1X+k","qrNtvY","b&e#Kj","w*3CHz","ByzqD7","XZEbUv","UbqERE","AR4zZ@","v@ttW5","0WK!a=","T4B2Kn","Sm31mb","Cv@gRH","52xASR","PYBMde","J&P6W7","PMVwUR","zsHZEV","HhaPP6","+XHf6@","&&bAfT","E6NVeq","9B25Z*","HJOSvq","P6sx=E","Xb7T@8","E@2ov$","aq&*C$","ymAb!s","vKKhPu","b$#HGd","KJ@2K6","n+5@m9","FJ5H0P","c0pGYo","6DN2ow","B@UfVm","hyTh1v","Tjz@*4","WC!%Cm","86Q1ZB","3!rZCk","p%NN$e","t9q4NS","#KbGco","xu%1AT","F+&8Bq","Wh@#d8","TVazOy","oh9EN6","O8WpCr","4KreYo","!RXuA2","Co9#Zg","NvJ0Y@","OCyD0+","s!DXpq","GSUoKg","3b2EX7","XMJgpn","oxdj1T","g2$!0$","P96w=j","uf7+#W","KezYSS","oHbQRw","$8%0OX","CUPxQh","X2PAJc","s72EEB","YKw+oS","RRGj!1","UM9tuO","r*!CCk","u*U645","7vnpfw","B#bkB9","fnspqR","rAfwRe","5m8%vg","eR@P#x","5R!Guu","5aWxP2","sPq&oD","05Y1Nm","Tn=Ekh","!5T9=8","bUpSm&","=MWcFB","s7uyQO","aZsqm5","UfF4PO","w@Qe6g","wQrqm5","p35Uj6","mHZGz=","K+K806","sSUMgd","+X24ta","FvX$+K","uhYu69","47Kyq$","QRKW8z","1vBTfg","TURDVd","@Zkz4w","rtrH+6","F#cqCB","cFp!wH","7PVSar","ck$4EH","MxW%HP","TZ2eRu","dP&Ous","KogQ29","W5e&Oa","t79F&#","*K5cyE","xRttNZ","8!JXMe","X!0h0J","W2d=u&","h4%pv!","P%vBS0","6wT9mq","*yM8$g","fN$m&n","ba8XJj","YgU98e"
        };

        static void Main(string[] args)
        {
             
            //define arrays
            string[] names1 = new string[] 
            {
                "mahesh","sabnis","manish","sharma","saket","karnik"
            };

            string[] names2 = new string[] 
            {
                "suprotim","agarwal","vikram","pendse","mahesh","mitkari"
            };

            //2.
            //define hashsets
            HashSet<string> hSetN1 = new HashSet<string>(names1);
            Console.WriteLine("Data in First HashSet");
            foreach (var n in hSetN1)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("_______________________________________________________________");
            HashSet<string> hSetN2 = new HashSet<string>(names2);
            Console.WriteLine("Data in Second HashSet");
            foreach (var n in hSetN2)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("________________________________________________________________");
            //3.
            Console.WriteLine("Data After Union");
            hSetN1.UnionWith(hSetN2);
            Console.WriteLine("Combined set count: " + hSetN1.Count);
            foreach (var n in hSetN1)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("________________________________________________________________");
            Console.WriteLine("Using HashSet");
            //1. Defining String Array (Note that the string "mahesh" is repeated) 
            string[] names = new string[] 
            {
                "mahesh",
                "vikram",
                "mahesh",
                "mayur",
                "suprotim",
                "saket",
                "manish"
            };

            //2. Length of Array and Printing array
            Console.WriteLine("Length of Array " + names.Length);
            Console.WriteLine();
            Console.WriteLine("The Data in Array");
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();
            //3. Defining HashSet by passing an Array of string to it
            HashSet<string> hSet = new HashSet<string>(names);
            //4. Count of Elements in HashSet
            Console.WriteLine("Count of Data in HashSet " + hSet.Count);
            Console.WriteLine();
            //5. Printing Data in HashSet, this will eliminate duplication of "mahesh" 
            Console.WriteLine("Data in HashSet");
            foreach (var n in hSet)
            {
                Console.WriteLine(n);
            }
            

            //Section 4. exceptwith

            Console.WriteLine();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Data in HashSet before using Except With");
            Console.WriteLine("---------------------------------");
            //storing data of hSetN3 in temporary HashSet
            HashSet<string> hSetN3 = new HashSet<string>(names1);
            foreach (var n in hSetN3)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Using Except With");
            Console.WriteLine("_________________________________");
            hSetN3.ExceptWith(hSetN2);
            foreach (var n in hSetN3)
            {
                Console.WriteLine(n);
            }

            //Section 5. SymmetricExceptWith()
            HashSet<string> hSetN4 = new HashSet<string>(names1);
            Console.WriteLine("_________________________________");
            Console.WriteLine("Elements in HashSet before using SymmetricExceptWith");
            Console.WriteLine("_________________________________");
            Console.WriteLine("HashSet 1");
            foreach (var n in hSetN4)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("HashSet 2");
            foreach (var n in hSetN2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("_________________________________");
            Console.WriteLine("Using SymmetricExceptWith");
            Console.WriteLine("_________________________________");
            hSetN4.SymmetricExceptWith(hSetN2);
            foreach (var n in hSetN4)
            {
                Console.WriteLine(n);
            }

            //Section 6. Performance

            //Add performance check

            //When adding items I a list, the items just get added, but with a HashSet,
            //it has to check and skip if an item already exists as a HashSet cannot contain
            //duplicates therefore hashsets are slower.
            Get_Add_Performance_HashSet_vs_List(); 

            //A HashSet is faster than a list since every value is unique,
            //so the HashSet can use hashes to find the item faster.
            Get_Contains_Performance_HashSet_vs_List();
            
            //The remove operation is faster in a HashSet than in a list.
            //This is because the HashSet uses a hash to find the item to remove just like the contains operation.
            Get_Remove_Performance_HashSet_vs_List();
        }

        //add performance check
        static void Get_Add_Performance_HashSet_vs_List()
        {

            Console.WriteLine("____________________________________");
            Console.WriteLine("HashSet Performance while Adding Item");
            Console.WriteLine();
            HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
            var s1 = Stopwatch.StartNew();
            foreach (string s in namesLarge)
            {
                hStringNames.Add(s);
            }
            s1.Stop();

            Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine("____________________________________");
            Console.WriteLine();




            //Console.WriteLine("____________________________________");
            Console.WriteLine("List Performance while Adding Item");
            Console.WriteLine();
            List<string> lstNames = new List<string>();
            var s2 = Stopwatch.StartNew();
            foreach (string s in namesLarge)
            {
                lstNames.Add(s);
            }
            s2.Stop();

            Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine();
            

            

           


        }

        //Contains performance check
        static void Get_Contains_Performance_HashSet_vs_List()
        {
            Console.WriteLine("____________________________________");
            Console.WriteLine("HashSet Performance while checking Contains operation");
            Console.WriteLine();

            HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
            var s1 = Stopwatch.StartNew();
            foreach (string s in namesLarge)
            {
                hStringNames.Contains(s);
            }
            s1.Stop();

            Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms"));
            Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine("____________________________________");
            Console.WriteLine();


            //Console.WriteLine("____________________________________");
            Console.WriteLine("List Performance while checking Contains operation");
            Console.WriteLine();
            List<string> lstNames = new List<string>();
            var s2 = Stopwatch.StartNew();
            foreach (string s in namesLarge)
            {
                lstNames.Contains(s);
            }
            s2.Stop();

            Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine();
            

        }

        //remove performance check
        static void Get_Remove_Performance_HashSet_vs_List()
        {
            Console.WriteLine("____________________________________");
            Console.WriteLine("HashSet Performance while performing Remove item operation");
            Console.WriteLine();

            HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
            var s1 = Stopwatch.StartNew();
            foreach (string s in namesLarge)
            {
                hStringNames.Remove(s);
            }
            s1.Stop();

            Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            //Console.WriteLine("____________________________________");
            Console.WriteLine();


            Console.WriteLine("____________________________________");
            Console.WriteLine("List Performance while performing Remove item operation");
            Console.WriteLine();
            List<string> lstNames = new List<string>();
            var s2 = Stopwatch.StartNew();
            foreach (string s in namesLarge)
            {
                lstNames.Remove(s);
            }
            s2.Stop();

            Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine();
            

        }
    }
}

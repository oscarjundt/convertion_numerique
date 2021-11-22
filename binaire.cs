/*
###########################################################
# programme de conversion binaire/decimal decimal/binaire #
# fait par oscar jundt-schmitter                          #
###########################################################
*/
using System;
using System.Collections.Generic;
class bin{
    static void Main(){
        //declaration de la liste t
        List<int> t = new List<int>();
        //demande a l'utilisateur si qu'elle type de conversion il veux
        Console.Write("binaire->decimal ou decimal->binaire: ");
        string mot = Console.ReadLine();
        //declaration est initialisation des differente variable
        int a;
        string a2;
        int res=0;
        //pour la conversion binaire->decimal
        if(mot=="binaire->decimal"){
            //demande a l'utilisateur le nombre en binaire
            Console.Write("donner nombre binaire: ");
            a2=Console.ReadLine();
            //appelle la focntion pour la conversion
            conversion_binaire_decimal(t,res,a2);
        }
        //pour la conversion decimal->binaire
        else if(mot=="decimal->binaire"){
            //demande a l'utilisateur le nombre decimal
            Console.Write("donner nombre decimal: ");
            a = int.Parse(Console.ReadLine());
            //appelle de la fonction d'initailisaton de la liste
            ini(t,res,a);
            //appelle de la fonction de conversion
            conversion_decimal_binaire(t,res,a);
        }
        
    }
    /*
    fonction de type void qui convertie un nombre binaire en decimal
    entrer : la liste t, le nombre en binaire demander a l'user
    sortie : la conversion du nombre donner en decimal
    */
    public static void conversion_binaire_decimal(List<int> t,int res,string a2){
        int e=1;
        double re=0;
        char re2;
        int resul=0;
        for(int i=0;i<a2.Length;i++){
            t.Add(e);
            e=e*2;
        }
        for(int i=t.Count-1;i>=0;i--){
            if(a2[resul]=='1'){
                re=re+t[i];
            }
            resul++;
        }
        Console.WriteLine(re);

    }
    public static void conversion_decimal_binaire(List<int> t, int res, int a){
        for(int i=t.Count-1;i>=0;i--){
            if(t[i]<=a){
                Console.Write("1");
                a-=t[i];
            }
            else{
                Console.Write("0");
            }
        }
    }
    /*
    fonction de type void qui initalise la liste
    entrer : la liste, le nombre decimal donner par l'utilisateur
    */
    public static void ini(List<int> t,int res,int a){
        for(int i=1;i<=a;i*=2){
            t.Add(i);
            res++;
        }
    }
}
List<object> myList=new List<object>();
myList.Add(7);
myList.Add(28);
myList.Add(-1);
myList.Add(true);
myList.Add("chair");
int sum=0;
for (int i=0;i<myList.Count;i++){
    Console.WriteLine(myList[i]);
    if(myList[i] is int){
        sum+=(int)myList[i];
    }
}
Console.WriteLine(sum);
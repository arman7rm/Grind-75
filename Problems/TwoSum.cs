public partial class Solution{

//Speed Efficient Solution
    public void TwoSum(int[] arr, int target){
        var map = new Dictionary<int,List<int>>();
        for(int i=0; i<arr.Length; i++){
            if(!map.ContainsKey(arr[i]))map[arr[i]] = [];
            map[arr[i]].Add(i);
        }
        for(int i=0; i<arr.Length; i++){
            int complement = target-arr[i];
            if(map.ContainsKey(complement)){
                foreach(int j in map[complement]){
                    if(j!=i){
                        Console.WriteLine(i+","+j);
                        return;
                    }
                }
            }
        }
    }

    //Memory Efficient Solution
    public void TwoSum2(int[] arr, int target){
        for(int i=0; i<arr.Length-1; i++){
            for(int j=i+1; j<arr.Length; j++){
                if(arr[i]+arr[j]==target){
                    Console.WriteLine(i+","+j);
                    return;
                }
            }
        }
    }
}
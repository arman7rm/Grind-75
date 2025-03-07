public partial class Solution{

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
}
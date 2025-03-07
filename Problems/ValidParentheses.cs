public partial class Solution{

// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

// An input string is valid if:

// Open brackets must be closed by the same type of brackets.
// Open brackets must be closed in the correct order.
// Every close bracket has a corresponding open bracket of the same type.

    public bool ValidParentheses(string s){
        var map = new Dictionary<char,char>();
        map[')'] = '(';
        map[']'] = '[';
        map['}'] = '{';
        string openings = "({[";
        var stack = new Stack<char>();
        for(int i=0; i<s.Length; i++){
            if(map.ContainsKey(s[i])){
                if(stack.Count==0 || stack.Peek()!=map[s[i]]){
                    return false;
                }
                stack.Pop();
            }
            if(openings.Contains(s[i])){
                stack.Push(s[i]);
            }
        }
        if(stack.Count==0){
            return true;
        }
        return false;
    }
}
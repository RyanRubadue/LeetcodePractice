
Solution s = new Solution();
TreeNode r = new TreeNode(10);
r.left = new TreeNode(5);
Console.WriteLine(s.PathSum(r, 15));


public class Solution {
    // public int MinDeletionSize(string[] strs) {
    //     bool[] sorted_cols = Enumerable.Repeat(true, strs[0].Length).ToArray();

    //     for(int i = 1; i < strs.Length; i++){
    //         for(int j = 0; j < strs[i].Length; j++){
    //             if(sorted_cols[j] == true){
    //                 sorted_cols[j] = strs[i][j] >= strs[i-1][j]; 
    //             }
    //         }
    //     }

    //     return sorted_cols.count(c => c == false);
    // }

    // public int LengthOfLastWord(string s) {
    //     lastWord = ""
    //     bool spaceSeen = false;

    //     foreach(char c in s){
    //         if(c != ' '){
    //             if(spaceSeen){
    //                 lastWord = "";
    //                 spaceSeen = false;
    //             }
    //             lastWord += c;
    //         }
    //         else{
    //             spaceSeen = true;
    //         }
    //     }

    //     return lastWord.Length;
    // }

    // public int SearchInsert(int[] nums, int target) {
    //     int curInd = nums.Length / 2;

    //     if(nums[curInd] < target){
    //         for(int i = curInd; i++; i< nums.Length){
    //             if(nums[i] >= target){return i;}
    //         }
    //         return nums.Length;
    //     }
    //     else{
    //         for(int i = curInd; i--; i >= 0){
    //             if(nums[i] = target){ return i; }
    //             else if(nums[i] < target){return i + 1;}
    //         }
    //         return 0;
    //     }
    // }

    // public int MinimumRounds(int[] tasks) {
    //     Dictionary<int, int> mapVals = new Dictionary<int, int>();

    //     // create mapping of task values to number of occurrences
    //     foreach(int t in tasks){
    //         if(!mapVals.ContainsKey(t)){
    //             mapVals[t] = 1;
    //         }
    //         else{
    //             mapVals[t] += 1;
    //         }
    //     }

    //     int minMoves = 0;

    //     //count minimum moves
    //     foreach(int key in mapVals.Keys){
    //         int keyVal = mapVals[key];

    //         while(keyVal > 3){
    //             if(keyVal != 4){
    //                 keyVal -= 3;
    //             }
    //             else{
    //                 keyVal -= 2;
    //             }
    //             minMoves++;
    //         }

    //         if(keyVal == 1){
    //             return -1;
    //         }

    //         minMoves++;
    //     }

    //     return minMoves;
    // }


    // public int FindMinArrowShots(int[][] points) {
    //     List<int[]> pList = points.ToList();
    //     pList = pList.OrderBy(p => p[1]).ToList();

    //     int minShots = 0;

    //     int start = pList[0][0], end = pList[0][1];
    //     for(int i = 1; i < pList.Count; i++){
    //         if(pList[i][0] > end){
    //             start = pList[i][0];
    //             end = pList[i][1];
    //             minShots+=1;
    //         }
    //         else{
    //             start = Math.Max(start, pList[i][0]);
    //             end = Math.Min(end, pList[i][1]);
    //         }
    //     }

    //     return minShots;
    // }

    // public int FindLengthOfLCIS(int[] nums) {
    //     if(nums.Count() == 0){ return 0; }

    //     int longestSeq = 1;
    //     int curSeq = 1;

    //     for(int i = 1; i < nums.Count(); i++){
    //         if(nums[i] > nums[i- 1]){
    //             curSeq +=1;
    //         }
    //         else{
    //             longestSeq = Math.Max(longestSeq, curSeq);
    //             curSeq = 1;
    //         }
    //     }
        
    //     longestSeq = Math.Max(longestSeq, curSeq);
    //     return longestSeq;
    // }

    // public int MaxIceCream(int[] costs, int coins) {
    //     List<int> cList = costs.ToList();
    //     cList.Sort();

    //     int iceCreamPurchases = 0;
    //     foreach(int cost in cList){
    //         if(cost <= coins){
    //             coins -= cost;
    //             iceCreamPurchases++;
    //         }
    //         else{
    //             return iceCreamPurchases;
    //         }
    //     }
    //     return iceCreamPurchases;
    // }

    // public bool IsPalindrome(string s) {
    //     string revStr = "";
    //     string modStr = "";

    //     foreach(char c in s){
    //         if(char.IsLetterOrDigit(c)){
    //             string insStr = char.ToLower(c).ToString();
    //             revStr = revStr.Insert(0, insStr);
    //             modStr += insStr;
    //         }
    //     }

    //     return revStr == modStr;
    // }



    // public IList<int> PreorderTraversal(TreeNode root) {
    //     return RecTrav(root, new List<int>());
    // }

    // public List<int> RecTrav(TreeNode node, List<int> preOrderedNodes){
    //     if(node == null){return preOrderedNodes;}

    //     preOrderedNodes.Add(node.val);
    //     RecTrav(node.left, preOrderedNodes);
    //     RecTrav(node.right, preOrderedNodes);

    //     return preOrderedNodes;
    // }

    // public IList<int> InorderTraversal(TreeNode root) {
    //     return RecTrav(root, new List<int>());
    // }

    // public IList<int> RecTrav(TreeNode node, List<int> inorderNodes){
    //     if(node == null){ return inorderNodes;}

    //     RecTrav(node.left, inorderNodes);
    //     inorderNodes.Add(node.val);
    //     RecTrav(node.right, inorderNodes);

    //     return inorderNodes;
    // }

    // public string AddBinary(string a, string b) {
    //     string result = "";

    //     int carryOver = 0;

    //     while(a.Length > 0 || b.Length > 0){
    //         int curDig = carryOver;
    //         if(a.Length > 0){
    //             curDig += (int)char.GetNumericValue(a.Last());
    //             a = a.Remove(a.Length - 1);
    //         }
    //         if(b.Length > 0){
    //             curDig += (int)char.GetNumericValue(b.Last());
    //             b = b.Remove(b.Length - 1);
    //         }

    //         if(curDig >= 2){
    //             carryOver = 1;
    //             curDig -= 2;
    //         }
    //         else{
    //             carryOver = 0;
    //         }

    //         Console.WriteLine(curDig);

    //         result = result.Insert(0, curDig.ToString());
    //     }

    //     if(carryOver == 1){
    //         result = result.Insert(0, 1.ToString());
    //     }

    //     return result;
    // }


    // public bool CloseStrings(string word1, string word2) {
    //     if(word1.Length != word2.Length){return false;}

    //     Dictionary<char, int> word1CharMap = GetCharCounts(word1);
    //     List<int> word1CharCounts = word1CharMap.Values.ToList();
    //     word1CharCounts.Sort();

    //     Dictionary<char, int> word2CharMap = GetCharCounts(word2);
    //     List<int> word2CharCounts = word2CharMap.Values.ToList();
    //     word2CharCounts.Sort();

    //     foreach(char key in word1CharMap.Keys){
    //         if(!word2CharMap.ContainsKey(key)){
    //             return false;
    //         }
    //     }

    //     for(int i = 0; i < word1CharCounts.Count; i++){
    //         if(word1CharCounts[i] != word2CharCounts[i]){
    //             return false;
    //         }
    //     }

    //     return true;
    // }

    // public Dictionary<char, int> GetCharCounts(string s){
    //     Dictionary<char, int> charCounts = new Dictionary<char, int>();
    //     foreach(char c in s){
    //         if(!charCounts.ContainsKey(c)){
    //             charCounts.Add(c, 1);
    //         }
    //         else{
    //             charCounts[c] += 1;
    //         }
    //     }

    //     return charCounts;
    // }

    // public int MatchPlayersAndTrainers(int[] players, int[] trainers) {
    //     int matchings = 0;

    //     players = players.OrderBy(c => c).ToArray();
    //     trainers = trainers.OrderBy(c => c).ToArray();

    //     int trainerIndex = 0;

    //     foreach(int player in players){
    //         bool matchFound = false;
    //         for(int i = trainerIndex; i < trainers.Count(); i++){
    //             if(trainers[i] >= player){
    //                 trainerIndex = i;
    //                 matchings += 1;
    //                 matchFound = true;
    //                 break;
    //             }
    //         }
    //         if(!matchFound){return matchings;}

    //     }

    //     return matchings;
    // }

    // public bool IsSameTree(TreeNode p, TreeNode q) {
    //     return RecNodeCheck(p, q);
    // }

    // public bool RecNodeCheck(TreeNode pNode, TreeNode qNode){
    //     if(pNode == null && qNode == null){return true;} 
    //     if(pNode == null || qNode == null || pNode.val != qNode.val){return false;}

    //     return(RecNodeCheck(pNode.left, qNode.left) && RecNodeCheck(pNode.right, qNode.right));
    // }


    // public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
    //     return FindSums(root, targetSum, 0, new List<IList<int>>(), new List<int>());
    // }

    // public List<IList<int>> FindSums(TreeNode node, int targetSum, int curSum, List<IList<int>> foundPaths, List<int> curPath){
    //     if(node == null){
    //         return foundPaths;
    //     }
    //     else{
    //         List<int> modPath = new List<int>(curPath);
    //         modPath.Add(node.val);
    //         curSum += node.val;


    //         if(node.left == null && node.right == null){
    //             if(curSum == targetSum){
    //                 foundPaths.Add(modPath);
    //             }
    //             return foundPaths;
    //         }
    //         else{
    //             foundPaths = FindSums(node.left, targetSum, curSum, foundPaths, modPath);
    //             foundPaths = FindSums(node.right, targetSum, curSum, foundPaths, modPath);
    //         }
            
    //     }
    //     return foundPaths;
    // }

    // public bool IsHappy(int n){
    //     HashSet<int> numsSeen = new HashSet<int>();

    //     while(n != 1){
    //         int curSum = 0;
    //         foreach(char c in n.ToString()){
    //             curSum += (int)Math.Pow((int)char.GetNumericValue(c), 2);
    //         }
    //         if(numsSeen.Contains(curSum)){return false;}
    //         numsSeen.Add(curSum);
    //         n = curSum;
    //     }

    //     return true;
    // }

    // public int[] FindBall(int[][] grid) {
    //     int[] ballLoc = new int[grid[0].Count()];

    //     for(int colInd = 0; colInd < grid[0].Count(); colInd++){

    //         int curCol = colInd;

    //         for(int curRow = 0; curRow < grid.Count(); curRow++){

    //             if(grid[curRow][curCol] == 1){
    //                 if(curCol == (grid[0].Count() -1) || grid[curRow][curCol + 1] == -1){
    //                     curCol = -1;
    //                     break;
    //                 }
    //                 else{
    //                     curCol++;
    //                 }
    //             }
    //             else{
    //                 if(curCol == 0 || grid[curRow][curCol - 1] == 1){
    //                     curCol = -1;
    //                     break;
    //                 }
    //                 else{
    //                     curCol--;
    //                 }
    //             }
    //         }
        
    //         ballLoc[colInd] = curCol;
    //     }

    //     return ballLoc;
    // }

    // public int[] DiStringMatch(string s) {
    //     int[] result = new int[s.Length];

    //     int lowInd = 0;
    //     int highInd = s.Length;
    //     int insertInd = 0;

    //     foreach(char c in s){
    //         if(c == 'I'){
    //             result[insertInd] = lowInd;
    //             lowInd++;
    //         }
    //         else{
    //             result[insertInd] = highInd;
    //             highInd--;
    //         }
    //         insertInd++;
    //     }

    //     result[insertInd] = lowInd;

    //     return result;
    // }

    // public string LongestCommonPrefix(string[] strs) {
        
    //     string longestPref = "";
        
    //     for(int i = 0; i < strs[0].Length; i++){
    //         char curChar = strs[0][i];

    //         for(int j = 1; j < strs.Length; j++){
    //             if(strs[j].Length <= i || strs[j][i] != curChar){
    //                 return longestPref;
    //             }
    //         }

    //         longestPref += curChar;
    //     }

    //     return longestPref;
    // }

    // public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
    //     ListNode retHead = new ListNode();
    //     ListNode curNode = retHead;

    //     int carry = 0;

    //     while(l1 != null || l2 != null){
    //         int nodeSum = carry;

    //         if(l1 != null){
    //             nodeSum += l1.val;
    //             l1 = l1.next;
    //         }

    //         if(l2 != null){
    //             nodeSum += l2.val;
    //             l2 = l2.next;
    //         }

    //         carry = (int)(nodeSum /10);
    //         curNode.next = new ListNode(nodeSum % 10);
    //         curNode = curNode.next;
    //     }
    
    //     if(carry > 0){
    //         curNode.next.val = carry;
    //     }
    //     else{
    //         curNode.next = null;
    //     }

    //     return retHead.next;
    // }


    // public ListNode RemoveNthFromEnd(ListNode head, int n) {
    //     ListNode start = new ListNode(0);
    //     ListNode curNode = start, delNode = start;
    //     delNode.next = head;

    //     for(int i = 0; i <= n; i++){
    //         curNode = curNode.next;
    //     }   


    //     while(curNode != null){
    //         curNode = curNode.next;
    //         delNode = delNode.next;
    //     }

    //     delNode.next = delNode.next.next;
    //     return start.next;

    // }

    // public ListNode SortList(ListNode head) {
    //     SortedList<int, int> sortedNodes = new SortedList<int, int>();

    //     //store values of node counts in ascending order
    //     while(head != null){
    //         if(!sortedNodes.ContainsKey(head.val)){
    //             sortedNodes.Add(head.val, 1);
    //         }
    //         else{
    //             sortedNodes[head.val] += 1;
    //         }
    //     }

    //     if(sortedNodes.Count == 0){return null;}

    //     ListNode sortedHead = new ListNode(sortedNodes.First().Key);
    //     ListNode curNode = sortedHead;
    //     sortedNodes[sortedNodes.First().Key] -= 1;

    //     foreach(int k in sortedNodes.Keys){
    //         for(int i = 0; i < sortedNodes[k]; i++){
    //             curNode.next = new ListNode(k);
    //             curNode = curNode.next;
    //         }
    //     }

    //     return sortedHead;
    // }


// public int LongestPalindrome(string[] words) {
//         Dictionary<string, int> unpairedWords = new Dictionary<string, int>();
//         int palLength = 0;

//         foreach(string word in words){
//             string revWord = Reverse(word);
//             // if reverse of current word has been seen: 1) add 2 to length 2) remove unpaired if count was 1 or decrement if > 1
//             if(unpairedWords.ContainsKey(revWord)){
//                 palLength+=4;
//                 if(unpairedWords[revWord] > 1){
//                     unpairedWords[revWord] -= 1;
//                 }
//                 else{
//                     unpairedWords.Remove(revWord);
//                 }
//             }
//             else{
//                 if(unpairedWords.ContainsKey(word)){
//                     unpairedWords[word] += 1;
//                 }
//                 else{
//                     unpairedWords.Add(word, 1);
//                 }
//             }
//         }

//         foreach(string s in unpairedWords.Keys){
//             if(s[0] == s[1]){
//                 palLength += 2;
//                 break;
//             }
//         }

//         return palLength;
//     }

//     public static string Reverse( string s )
//     {
//         char[] charArray = s.ToCharArray();
//         Array.Reverse(charArray);
//         return new string(charArray);
//     }

//todo
    // public int LeastInterval(char[] tasks, int n) {
    //     int completionTime = 0;
    //     Dictionary<char, int> taskMap = new System.Collections.Generic.Dictionary<char, int>();

    //     // map each task to number of occurrences in task list

    //     foreach(char c in tasks){
    //         if(taskMap.ContainsKey(c)){
    //             taskMap[c] += 1;
    //         }
    //         else{
    //             taskMap.Add(c, 1);
    //         }
    //     }


        
    //     return completionTime;
    // }


    // public TreeNode InvertTree(TreeNode root) {
    //     if(root == null){return root;}
    //     RecInv(root);
    //     return root;
    // }


    // public int RecInv(TreeNode node){

    //     if(node.right != null && node.left != null){
    //         TreeNode t = node.left;
    //         node.left = node.right;
    //         node.right = t;

    //         if(node.left != null){RecInv(node.left);}
    //         if(node.right != null){RecInv(node.right);}
    //     }

    //     return node.val;
    // }

    // public int LeastInterval(char[] tasks, int n) {
    //     int taskTime = 0;
    //     Dictionary<char, int> taskMap = new Dictionary<char, int>();

    //     int maxCount = 0;
    //     int maxVal = 0;

    //     // map each character to number of occurrences in array
    //     foreach(char c in tasks){
    //         if(taskMap.ContainsKey(c)){
    //             taskMap[c] += 1;
    //         }
    //         else{
    //             taskMap.Add(c, 1);
    //         }

    //         if(maxVal == taskMap[c]){maxCount+=1;}
    //         else if(maxVal < taskMap[c]){
    //             maxVal = taskMap[c];
    //             maxCount = 1;
    //         }
    //     }

    //     int pCount = maxVal - 1;
    //     int pLen = n - (maxCount - 1);
    //     int emptySlots = pCount * pLen;
    //     int availableTasks = tasks.Count() - maxVal * maxCount;
    //     int idles = Math.Max(0, emptySlots - availableTasks);

    //     return tasks.Count() + idles;

    // }


    // public int DiameterOfBinaryTree(TreeNode root) {
    //     (int, int) pathComp = RecDiameter(root, 0);
    //     return pathComp.Item2;
    // }

    // public (int, int) RecDiameter(TreeNode node, int curDist){
    //     if(node == null){
    //         return (0, 0);
    //     }

    //     (int, int) lDist = RecDiameter(node.left, curDist);
    //     (int, int) rDist = RecDiameter(node.right, curDist);

    //     Console.WriteLine(node.val);
    //     Console.WriteLine(lDist);
    //     Console.WriteLine(rDist);
    //     Console.WriteLine("\n\n\n");

    //     curDist += 1;

    //     int longestComp = Math.Max(lDist.Item1, rDist.Item1) + 1;
    //     int longestPath = Math.Max(rDist.Item2, lDist.Item2);
    //     longestPath = Math.Max(longestPath, lDist.Item1 + rDist.Item1);


    //     return (longestComp, longestPath);
    // }


// public int PathSum(TreeNode root, int targetSum) {
//         List<long> sumVals = new List<long>();
//         return RecSum(root, targetSum, sumVals, 0);
//     }

//     public int RecSum(TreeNode node, int targetSum, List<long> sumVals, int pathCount){
//         if(node == null){
//             return pathCount;
//         }

//         sumVals = sumVals.Append(node.val).ToList();
//         // check all path lengths leading to current node
//         long pathSumCheck = 0;
//         for(int i = sumVals.Count - 1; i >= 0; i--){
//             pathSumCheck += sumVals[i];
//             if(pathSumCheck == targetSum){pathCount += 1;}
//         }

//         pathCount = RecSum(node.left, targetSum, new List<long>(sumVals), pathCount);
//         pathCount = RecSum(node.right, targetSum, new List<long>(sumVals), pathCount);

//         return pathCount;

//     }


    // public int Search(int[] nums, int target) {
    //     int low = 0;
    //     int high = nums.Count() - 1;
        
    //     while(low < high){
    //         int mid = (low + high) / 2;

    //         if(nums[mid] > nums[high]){low = mid + 1;}
    //         else{high = mid;}
    //     }

    //     int rotInd = low;

    //     low = 0;
    //     high = nums.Count() - 1;

    //     while(low <= high){
    //         int mid = (low + high) / 2;
    //         int realMid = (mid + rotInd) % nums.Count();

    //         if(nums[realMid] == target){return realMid;}
    //         if(nums[realMid] < target){low = mid + 1;}
    //         else{high = mid -1;}
    //     }

    //     return -1;
    // }


    // public TreeNode SortedArrayToBST(int[] nums) {
    //     int treeHeight = (int)Math.Log2(nums.Count());
    //     return RecTree(new TreeNode())

    // }

    // public void RecTree(TreeNode node, int hCount){

    // }


    public int KthSmallest(TreeNode root, int k) {
        List<int> kSmallestNums = new List<int>();

        List<int> smallNums = KthSmallestHelper(root, k, kSmallestNums);

        if(smallNums.Count == 0){return -1;}
        return smallNums.OrderBy(k => k).ToList()[smallNums.Count - 1];

    }

    public List<int> KthSmallestHelper(TreeNode node, int k, List<int> kSmallestNums)
    {
        if(node == null){
            return kSmallestNums;
        }

        kSmallestNums = kSmallestNums.Append(node.val).ToList();

        if(kSmallestNums.Count > Math.Max(k, 0)){
            kSmallestNums = kSmallestNums.OrderBy(k => k).ToList();
            kSmallestNums.RemoveAt(kSmallestNums.Count - 1);
        }
        
        KthSmallestHelper(node.left, k, kSmallestNums);
        KthSmallestHelper(node.right, k, kSmallestNums);

        return kSmallestNums;
    }
}

  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }


  public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
      }
 }



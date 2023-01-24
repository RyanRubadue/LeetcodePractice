from typing import List, Optional


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

class Solution:
    # def minDeletionSize(self, strs: List[str]) -> int:
    #     col_check = [True for s in strs[0]]
    #
    #     for strs_ind, s in enumerate(strs):
    #         if strs_ind == 0:
    #             continue
    #         for char_ind, c in enumerate(s):
    #             if col_check[char_ind] == True:
    #                 col_check[char_ind] = strs[strs_ind][char_ind] >= strs[strs_ind - 1][char_ind]
    #
    #     return sum(map(lambda c : c == False, col_check))

    # def lengthOfLastWord(self, s: str) -> int:
    #     spltStr = s.split(" ")
    #     spltStr.reverse()
    #
    #     for i in spltStr:
    #         if any(c != ' ' for c in i):
    #             return len(i)
    #     return 0

    # def searchInsert(self, nums: List[int], target: int) -> int:
    #     if nums[int(len(nums) / 2)] < target:
    #         for i in range(int(len(nums) / 2), len(nums)):
    #             if nums[i] >= target:
    #                 return i
    #         return len(nums)
    #
    #     else:
    #         for i in range(int(len(nums) / 2), 0, -1):
    #             if nums[i] == target:
    #                 return i
    #             elif nums[i] < target:
    #                 return i + 1
    #         return 0
    #
    #     def maxIceCream(self, costs: List[int], coins: int) -> int:
    #         costs.sort()
    #         purchasedIceCreams = 0
    #
    #         for cost in costs:
    #             if(cost <= coins):
    #                 coins -= cost
    #                 purchasedIceCreams += 1
    #             else:
    #                 return purchasedIceCreams
    #         return purchasedIceCreams


    # def isPalindrome(self, s: str) -> bool:
    #     s = s.lower()
    #     s = ''.join(c for c in s if c.isalnum())
    #     return s == s[::-1]

    class TreeNode:
        def __init__(self, val=0, left=None, right=None):
            self.val = val
            self.left = left
            self.right = right

    # def preorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
    #
    #     preorderedNodes = []
    #
    #     def DFS(node):
    #         if node == None:
    #             return
    #
    #         preorderedNodes.append(node.val)
    #         DFS(node.left)
    #         DFS(node.right)
    #
    #     DFS(root)
    #     return


    # def inorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
    #     inorderNodes = []
    #
    #     def RecInOrder(node):
    #         if node == None:
    #             return
    #
    #         RecInOrder(node.left)
    #         inorderNodes.append(node.val)
    #         RecInOrder(node.right)
    #
    #     RecInOrder(root)
    #     return inorderNodes


    # def addBinary(self, a: str, b: str) -> str:
    #         res = ""
    #
    #         carryOver = 0
    #
    #         while len(a) > 0 or len(b) > 0:
    #             curDig = carryOver
    #
    #             if len(a) > 0:
    #                 curDig += int(a[-1])
    #                 a = a[0:len(a) - 1]
    #
    #             if len(b) > 0:
    #                 curDig += int(b[-1])
    #                 b = b[0:len(b) - 1]
    #
    #             if curDig >= 2:
    #                 carryOver = 1
    #                 curDig -= 2
    #             else:
    #                 carryOver = 0
    #
    #             res = str(curDig) + res
    #
    #         if carryOver == 1:
    #             res = str(carryOver) + res
    #
    #         return res

    # def isSameTree(self, p: Optional[TreeNode], q: Optional[TreeNode]) -> bool:
    #     if p == None and q == None:
    #         return True
    #     if p == None or q == None or p.val != q.val:
    #         return False
    #
    #     return self.isSameTree(p.left, q.left) and self.isSameTree(p.right, q.right)

    # def isHappy(self, n: int) -> bool:
    #     numsSeen = set()
    #
    #     while n != 1:
    #         curSum = 0
    #         for c in str(n):
    #             curSum += int(c) ** 2
    #         if curSum in numsSeen:
    #             return False
    #         n = curSum
    #         numsSeen.add(curSum)
    #     return True

    # def spiralOrder(self, matrix: List[List[int]]) -> List[int]:
    #     spiralNums = []
    #
    #     colStartInd = 0
    #     colEndInd = len(matrix[0])
    #
    #     rowStartInd = 0
    #     rowEndInd = len(matrix)
    #
    #     while colStartInd < colEndInd and rowStartInd < rowEndInd:
    #         if rowStartInd < rowEndInd:
    #             for i in range(colStartInd, colEndInd):
    #                 spiralNums.append(matrix[rowStartInd][i])
    #             rowStartInd += 1
    #
    #         if rowStartInd < rowEndInd:
    #             for i in range(rowStartInd, rowEndInd):
    #                 spiralNums.append(matrix[i][colEndInd])
    #             colEndInd -= 1
    #
    #         if rowStartInd < rowEndInd:
    #             for i in range(rowEndInd, rowStartInd - 1):
    #                 spiralNums.append(matrix[rowEndInd][i])
    #             rowEndInd -= 1
    #
    #         if colStartInd < colEndInd:
    #             for i in range(rowEndInd, rowStartInd - 1):
    #                 spiralNums.append(matrix[i][colStartInd])
    #             colStartInd += 1
    #
    #     return spiralNums

    # def multiply(self, num1: str, num2: str) -> str:
    #     num1 = num1[::-1]
    #     num2 = num2[::-1]
    #
    #     multSum = 0
    #     decShift = 0
    #     for d1 in num1:
    #         carry = 0
    #         curNum = ""
    #
    #         for i in range(0, decShift):
    #             curNum = "0" + curNum
    #
    #         for d2 in num2:
    #             #print(carry)
    #             mult = int(d1) * int(d2) + carry
    #
    #             if mult <= 9:
    #                 curNum = str(mult) + curNum
    #                 carry = 0
    #             else:
    #
    #                 mod = int(mult % 10)
    #                 #print(mod)
    #                 curNum = str(mod) + curNum
    #                 carry = int(mult / 10)
    #         if carry > 0:
    #             curNum = carry + curNum
    #
    #         print(curNum)
    #
    #         decShift += 1
    #         multSum += int(curNum)
    #
    #     return str(multSum)

    #

    # def oddEvenList(self, head: Optional[ListNode]) -> Optional[ListNode]:
    #     oddHead = ListNode(0)
    #     curOdd = oddHead
    #     evenHead = ListNode(0)
    #     curEven = evenHead
    #
    #     curNode = head
    #     evenInd = True
    #     while curNode is not None:
    #         if evenInd:
    #             curEven.next = curNode
    #             curEven = curEven.next
    #         else:
    #             curOdd.next = curNode
    #             curOdd = curOdd.next
    #         evenInd = not evenInd
    #
    #     curOdd.next = evenHead.next
    #     return oddHead.next

    # def isBalanced(self, root: Optional[TreeNode]) -> bool:
    #     balanced = True
    #
    #     def recDep(node, depth):
    #         if node is None:
    #             return depth
    #
    #         depth += 1
    #         ld = recDep(node.left, depth)
    #         rd = recDep(node.right, depth)
    #
    #         if abs(ld - rd) > 1:
    #             nonlocal balanced
    #             balanced = False
    #
    #         depth = max(ld, rd)
    #         return depth
    #
    #     recDep(root, 0)
    #
    #     return balanced

    # def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
    #     searchRow = 0
    #     for i, row in enumerate(matrix, start=0):
    #         if row[0] >= target:
    #             if row[0] == target:
    #                 return True
    #             elif i == 0:
    #                 return False
    #             searchRow = i - 1
    #             break
    #         else:
    #             searchRow = i
    #
    #     for i in matrix[searchRow]:
    #         if i == target:
    #             return True
    #
    #     return False

    # def sortedArrayToBST(self, nums: List[int]) -> Optional[TreeNode]:
    #     if len(nums) == 0:
    #         return None
    #
    #     mid = len(nums) // 2
    #
    #     return TreeNode(mid,
    #                     self.sortedArrayToBST(nums[:mid]),
    #                     self.sortedArrayToBST(nums[mid + 1:]))

    # class BSTIterator:
    #     nodes = []
    # 
    #     def __init__(self, root: Optional[TreeNode]):
    #         self.fillNodes(root)
    #
    #     def fillNodes(self, node: TreeNode):
    #         if node is None:
    #             return
    #
    #         self.fillNodes(node.left)
    #         self.nodes.append(node.val)
    #         self.fillNodes(node.right)
    #
    #     def next(self) -> int:
    #         if not self.hasNext():
    #             return -1
    #
    #         return self.nodes.pop(0)
    #
    #     def hasNext(self) -> bool:
    #         return len(self.nodes) > 0






s = Solution()
print(s.searchMatrix([[1,3,5,7],[10,11,16,20],[23,30,34,60]], 3))



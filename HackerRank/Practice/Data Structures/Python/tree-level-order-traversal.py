class Node:
    def __init__(self, info): 
        self.info = info  
        self.left = None  
        self.right = None 
        self.level = None 

    def __str__(self):
        return str(self.info) 

class BinarySearchTree:
    def __init__(self): 
        self.root = None

    def create(self, val):  
        if self.root == None:
            self.root = Node(val)
        else:
            current = self.root
         
            while True:
                if val < current.info:
                    if current.left:
                        current = current.left
                    else:
                        current.left = Node(val)
                        break
                elif val > current.info:
                    if current.right:
                        current = current.right
                    else:
                        current.right = Node(val)
                        break
                else:
                    break

"""
Node is defined as
self.left (the left child of the node)
self.right (the right child of the node)
self.info (the value of the node)
"""
def levelOrder(root):
    #Write your code here
    height = findHeight(root, 0)

    for i in range(0,height):
        printLevel(root, i)


def findHeight(root, level):
    if root is None:
        return level;
    left = findHeight(root.left, level + 1)
    right = findHeight(root.right, level + 1)

    if left > right:
        return left
    return right

def printLevel(root, level):
    if level == 0:
        print(root.info, end=' ')
    else:
        if root.left is not None:
            printLevel(root.left, level - 1)
        if root.right is not None:
            printLevel(root.right, level - 1)

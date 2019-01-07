def main():
    key = 5  # key for incription 
    file = open("and.txt","w")
    with open("text.txt") as fileobj:
        for line in fileobj:  
           for ch in line:
               ans = chr(ord(ch)+key)
               print (ans,end="")
               print (chr(ord(ans)- 5),end="") # dicript key
               file.write(ans)
main()

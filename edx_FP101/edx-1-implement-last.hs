xs = [1, 2, 3]                
last xs = head( drop (length xs - 1) xs)
main = print (Main.last xs)
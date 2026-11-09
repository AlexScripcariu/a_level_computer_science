def main():
    for i in range(5):
        print("Hello world!")


main()

# Lexical analysis of code above:
# [Keyword: def]
# [Identifier: main]
# [Separator: (]
# [Separator: )]
# [Separator: :]
# [Keyword: for]
# [Identifier: i]
# [Keyword: in]
# [Identifier: range]
# [Separator: (]
# [Literal: 5]
# [Separator: )]
# [Separtor: :]
# [Keyword: print]
# [Separator: (]
# [Literal: "Hello world"]
# [Separator: )]
# [Identifier: main]
# [Separator: (]
# [Separator: )]

# Symbol table: 
# Index | Token         |   Token class
# 0     | def           | Keyword         
# 1     | main          | Identifier          
# 2     | (             | Separator         
# 3     | )             | Separator        
# 4     | :             | Separator          
# 5     | for           | Keyword          
# 6     | i             | Identifier          
# 7     | in            | Keyword          
# 8     | range         | Identifier          
# 9     | 5             | Literal          
# 10    | print         | Identifier         
# 11    | "Hello World" | Literal          

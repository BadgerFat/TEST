import itertools
def ganerate_permutations(N):
    mylist = [0]*N + list(range(1,N + 1))
    perm_set = itertools.permutations(mylist)
    f = open('text.txt', 'w')
    for i in perm_set:
        f.write (str(i) + '\n')
    f.close()
    return factorial(N+N)

def factorial(N):
    if (N <= 1):
        return 1
    return N*factorial(N-1)

print (ganerate_permutations(7))
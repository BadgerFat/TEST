perm = {
    '0':1,
    '1':0,
    '2':0,
    '3':0,
    '4':1,
    '5':0,
    '6':1,
    '7':0,
    '8':2,
    '9':1
    }
chisla = ['4','6','8','9','0','46','954','612','100','88','11']
holes = {}
for num in chisla:
    holes_count = 0
    for c in str(num):
        holes_count = holes_count + perm[c]
    holes[num] = holes_count
perm_c = dict(sorted(holes.items(),key=lambda x: (x[1],int(x[0]))))
print(perm_c)
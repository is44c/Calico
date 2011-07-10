# Heatbugs Diffusion Model for Calico Python
# Doug Blank <dblank@cs.brynmawr.edu>

from Graphics import *
from Myro import askQuestion
import random

size = 300
win = Window("Mousetrap Model", size, size)

picture = Picture(size, size, Color("blue"))
picture.draw(win)

def pick(x, y):
    return (x + random.random() * 10 - 5, y + random.random() * 10 - 5)

askQuestion("Click on the window to begin", ["ok"])
traps = [getMouse()]

steps = 0
while traps:
    steps += 1
    print(len(traps))
    next = []
    for x,y in traps:
        setColor(getPixel(picture,x,y), Color("red"))
        for i in range(2):
            x,y = pick(x, y)
            if getRed(getPixel(picture, x, y)) != 255:
                next.append((x,y))
    traps = next

print("Took", steps, "steps")
# Zombies, after

from Myro import *

win = Window(800, 600)
win.mode = "manual"

def makeZombie():
    x, y = random() * win.width, random() * win.height
    circle = Arrow((x, y))
    circle.fill = Color("green")
    circle.rotation = random() * 360
    circle.draw(win)
    circle.pen.outline = Color(pickOne(getColorNames()))
    circle.penDown()
    return circle

def distance(z1, z2):
    # minimum of wrap-around distances
    dists = []
    #for xy in [(-1, -1), (0, -1), (+1, -1),
    #           (-1,  0), (0,  0), (+1,  0),
    #           (-1, +1), (0, +1), (+1, +1)]:
    for xy in [(0,0)]:
        z3 = Point(z1.x + (xy[0] * win.width), z1.y + (xy[1] * win.height))
        dists.append(((z3.x - z2.x) ** 2 + (z3.y - z2.y) ** 2) ** 0.5)
    return min(dists)

def average(items):
    if len(items) == 0:
        return 0
    return sum(items)/len(items)

zombies = [makeZombie() for z in range(50)]

def animate():
    directions = [0] * len(zombies)
    for count in range(len(zombies)):
        z1 = zombies[count]
        others = []
        for z2 in zombies:
            dist = distance(z1.getCenter(), z2.getCenter())
            others.append((dist, z2))
        close = filter(lambda item: item[0] < 10, others)
        avg_dir = average([x[1].rotation % 360 for x in close])
        directions[count] = avg_dir + (random() * 10 - 5)

    for count in range(len(zombies)):
        z1 = zombies[count]
        if directions[count] != 0:
            z1.rotation = directions[count]
        z1.forward(5)
        if z1.x > win.width:
            z1.penUp()
            z1.x = z1.x - win.width
            z1.penDown()
        if z1.y > win.height:
            z1.penUp()
            z1.y = z1.y - win.height
            z1.penDown()
        if z1.x < 0:
            z1.penUp()
            z1.x = z1.x + win.width
            z1.penDown()
        if z1.y < 0:
            z1.penUp()
            z1.y = z1.y + win.height
            z1.penDown()
    win.step(.05)


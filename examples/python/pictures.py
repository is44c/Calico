import Myro
Myro.init("/dev/rfcomm1")
pic = Myro.takePicture()

#from Graphics import *
#win = Window()
#pic.draw(win)
Myro.show(pic)

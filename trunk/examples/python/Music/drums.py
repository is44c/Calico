# This Python program was automatically generated by Calico Jigsaw
# http://calicoproject.org

import Common
import Myro

t = .3
s1 = Myro.makeSound(calico.relativePath("../examples/sounds/closed-hat-trimmed.wav"))
s2 = Myro.makeSound(calico.relativePath("../examples/sounds/crash-trimmed.wav"))
s3 = Myro.makeSound(calico.relativePath("../examples/sounds/kick-trimmed.wav"))
s4 = Myro.makeSound(calico.relativePath("../examples/sounds/open-hat-trimmed.wav"))
s5 = Myro.makeSound(calico.relativePath("../examples/sounds/snare-trimmed.wav"))
for _ in xrange(3):
  for _ in xrange(4 * 2):
    s1.Play()
    Myro.wait(t)
  for _ in xrange(4):
    s1.Play()
    Myro.wait(t)
    s3.Play()
    Myro.wait(t)
  for _ in xrange(2):
    s1.Play()
    Myro.wait(t)
    s5.Play()
    Myro.wait(t)
    s1.Play()
    Myro.wait(t)
    s2.Play()
    Myro.wait(t)
  for _ in xrange(2):
    s4.Play()
    Myro.wait(t)
  Myro.wait(t * 4)

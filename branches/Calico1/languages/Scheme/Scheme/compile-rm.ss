(load "rm-transformer.ss")
(compile-level-output)
(delete-file "pjscheme-rm.ss")
(rm-transform-file "pjscheme-ds.ss" "pjscheme-rm.ss")
(exit)
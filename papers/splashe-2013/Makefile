paper.pdf: paper.tex listings.sty
	latex paper.tex
	dvips -Ppdf paper.dvi
	ps2pdf paper.ps
	evince paper.pdf

listings.sty: listings.dtx listings.ins lstdrvrs.dtx
	tex listings.ins

clean:
	rm -rf *.dvi *.ps *~ *.aux *.bbl *.blg *.log 


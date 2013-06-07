CalicoCalicoAnEcosystemforDynamicLanguages.pdf: CalicoAnEcosystemforDynamicLanguages.tex listings.sty
#	dos2unix CalicoAnEcosystemforDynamicLanguages.tex
	latex CalicoAnEcosystemforDynamicLanguages.tex
	dvips -Ppdf CalicoAnEcosystemforDynamicLanguages.dvi
	ps2pdf CalicoAnEcosystemforDynamicLanguages.ps
	evince CalicoAnEcosystemforDynamicLanguages.pdf

listings.sty: listings.dtx listings.ins lstdrvrs.dtx
	tex listings.ins

clean:
	rm -rf *.dvi *.ps *~ *.aux *.bbl *.blg *.log 


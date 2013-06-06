
CalicoCalicoAnEcosystemforDynamicLanguages.pdf: CalicoAnEcosystemforDynamicLanguages.tex
#	dos2unix CalicoAnEcosystemforDynamicLanguages.tex
	latex CalicoAnEcosystemforDynamicLanguages.tex
	dvips -Ppdf CalicoAnEcosystemforDynamicLanguages.dvi
	ps2pdf CalicoAnEcosystemforDynamicLanguages.ps
	evince CalicoAnEcosystemforDynamicLanguages.pdf

clean:
	rm -rf *.dvi *.ps *~ *.aux *.bbl *.blg *.log 


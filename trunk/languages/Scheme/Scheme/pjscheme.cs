#pragma warning disable 109
using System;

public class PJScheme:Scheme
{
   new public static object lit_aexp (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("lit-aexp"), (object) args));
   }

   new public static object var_aexp (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("var-aexp"), (object) args));
   }

   new public static object if_aexp (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("if-aexp"), (object) args));
   }

   new public static object assign_aexp (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("assign-aexp"), (object) args));
   }

   new public static object func_aexp (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("func-aexp"), (object) args));
   }

   new public static object define_aexp (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("define-aexp"), (object) args));
   }

   new public static object define_b_aexp (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("define!-aexp"), (object) args));
   }

   new public static object define_syntax_aexp (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("define-syntax-aexp"), (object) args));
   }

   new public static object begin_aexp (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("begin-aexp"), (object) args));
   }

   new public static object lambda_aexp (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("lambda-aexp"), (object) args));
   }

   new public static object mu_lambda_aexp (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("mu-lambda-aexp"), (object) args));
   }

   new public static object app_aexp (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("app-aexp"), (object) args));
   }

   new public static object try_catch_aexp (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("try-catch-aexp"), (object) args));
   }

   new public static object try_finally_aexp (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("try-finally-aexp"), (object) args));
   }

   new public static object try_catch_finally_aexp (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("try-catch-finally-aexp"),
		    (object) args));
   }

   new public static object raise_aexp (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("raise-aexp"), (object) args));
   }

   new public static object dict_aexp (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("dict-aexp"), (object) args));
   }

   new public static object help_aexp (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("help-aexp"), (object) args));
   }

   new public static object choose_aexp (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("choose-aexp"), (object) args));
   }

   static Function pc = null;
   static object aclauses_reg = symbol ("undefined");
   static object action_reg = symbol ("undefined");
   static object adatum_list_reg = symbol ("undefined");
   static object adatum_reg = symbol ("undefined");
   static object ap1_reg = symbol ("undefined");
   static object ap2_reg = symbol ("undefined");
   static object ap_reg = symbol ("undefined");
   static object apair1_reg = symbol ("undefined");
   static object apair2_reg = symbol ("undefined");
   static object args_reg = symbol ("undefined");
   static object asexps_reg = symbol ("undefined");
   static object avar_reg = symbol ("undefined");
   static object ax_reg = symbol ("undefined");
   static object bindings_reg = symbol ("undefined");
   static object bodies_reg = symbol ("undefined");
   static object buffer_reg = symbol ("undefined");
   static object char_reg = symbol ("undefined");
   static object chars_reg = symbol ("undefined");
   static object clauses_reg = symbol ("undefined");
   static object components_reg = symbol ("undefined");
   static object datum_reg = symbol ("undefined");
   static object depth_reg = symbol ("undefined");
   static object entries_reg = symbol ("undefined");
   static object env2_reg = symbol ("undefined");
   static object env_reg = symbol ("undefined");
   static object exception_reg = symbol ("undefined");
   static object exp_reg = symbol ("undefined");
   static object expected_terminator_reg = symbol ("undefined");
   static object exps_reg = symbol ("undefined");
   static object fail_reg = symbol ("undefined");
   static object filename_reg = symbol ("undefined");
   static object filenames_reg = symbol ("undefined");
   static object final_reg = symbol ("undefined");
   static object generator_reg = symbol ("undefined");
   static object handler_reg = symbol ("undefined");
   static object i_reg = symbol ("undefined");
   static object info_reg = symbol ("undefined");
   static object input_reg = symbol ("undefined");
   static object iterator_reg = symbol ("undefined");
   static object k2_reg = symbol ("undefined");
   static object k_reg = symbol ("undefined");
   static object keyword_reg = symbol ("undefined");
   static object line_reg = symbol ("undefined");
   static object list1_reg = symbol ("undefined");
   static object list2_reg = symbol ("undefined");
   static object lists_reg = symbol ("undefined");
   static object ls1_reg = symbol ("undefined");
   static object ls2_reg = symbol ("undefined");
   static object ls_reg = symbol ("undefined");
   static object macro_reg = symbol ("undefined");
   static object msg_reg = symbol ("undefined");
   static object p1_reg = symbol ("undefined");
   static object p2_reg = symbol ("undefined");
   static object pair1_reg = symbol ("undefined");
   static object pair2_reg = symbol ("undefined");
   static object path_reg = symbol ("undefined");
   static object pattern_reg = symbol ("undefined");
   static object proc_reg = symbol ("undefined");
   static object procs_reg = symbol ("undefined");
   static object s_reg = symbol ("undefined");
   static object src_reg = symbol ("undefined");
   static object sum_reg = symbol ("undefined");
   static object token_type_reg = symbol ("undefined");
   static object tokens_reg = symbol ("undefined");
   static object transformer_name_reg = symbol ("undefined");
   static object v1_reg = symbol ("undefined");
   static object v2_reg = symbol ("undefined");
   static object value1_reg = symbol ("undefined");
   static object value2_reg = symbol ("undefined");
   static object value3_reg = symbol ("undefined");
   static object value4_reg = symbol ("undefined");
   static object value_reg = symbol ("undefined");
   static object var_info_reg = symbol ("undefined");
   static object var_reg = symbol ("undefined");
   static object variable_reg = symbol ("undefined");
   static object vars_reg = symbol ("undefined");
   static object x_reg = symbol ("undefined");
   static object y_reg = symbol ("undefined");
   static object temp_2 = symbol ("undefined");
   static object temp_3 = symbol ("undefined");
   static object temp_4 = symbol ("undefined");
   static object temp_1 = symbol ("undefined");
   new public static object make_cont (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("continuation"), (object) args));
   }

   new public static void apply_cont ()
   {
      {
	 object temp_1 = null;
	 temp_1 = PJScheme.cdr ((object) k_reg);
	 if (true_q
	     (PJScheme.
	      Eq ((object) PJScheme.car ((object) temp_1),
		  (object) symbol ("<cont-1>"))))
	   {
	      object chars = null;
	      object fail = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      fail = PJScheme.list_ref ((object) temp_1, (object) 2);
	      chars = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value3_reg = fail;
	      value2_reg = chars;
	      value1_reg = value_reg;
	      k_reg = k;
	      pc = (Function) apply_cont3;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-2>"))))
	   {
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value_reg = PJScheme.list_to_vector ((object) value_reg);
	      k_reg = k;
	      pc = (Function) apply_cont;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-3>"))))
	   {
	      object v1 = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      v1 = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value_reg = PJScheme.cons ((object) v1, (object) value_reg);
	      k_reg = k;
	      pc = (Function) apply_cont;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-4>"))))
	   {
	      object x = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      x = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont ((object) symbol ("<cont-3>"),
				     (object) value_reg, (object) k);
	      x_reg = PJScheme.cdr ((object) x);
	      pc = (Function) unannotate_cps;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-5>"))))
	   {
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value_reg =
		 PJScheme.retag ((object) PJScheme.
				 list_to_vector ((object) value_reg),
				 (object) symbol ("none"));
	      k_reg = k;
	      pc = (Function) apply_cont;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-6>"))))
	   {
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value_reg =
		 PJScheme.retag ((object) value_reg,
				 (object) symbol ("none"));
	      k_reg = k;
	      pc = (Function) apply_cont;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-7>"))))
	   {
	      object x = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      x = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont ((object) symbol ("<cont-3>"),
				     (object) value_reg, (object) k);
	      x_reg = PJScheme.cdr ((object) x);
	      pc = (Function) reannotate_seq_cps;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-8>"))))
	   {
	      final_reg = value_reg;
	      pc = null;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-9>"))))
	   {
	      object bindings = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      bindings = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value_reg =
		 PJScheme.append ((object) PJScheme.
				  list ((object) symbol ("let")),
				  (object) PJScheme.append ((object) PJScheme.
							    list ((object)
								  PJScheme.
								  list ((object) PJScheme.car ((object) bindings))), (object) PJScheme.list ((object) value_reg)));
	      k_reg = k;
	      pc = (Function) apply_cont;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-10>"))))
	   {
	      object clauses = null;
	      object var = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      var = PJScheme.list_ref ((object) temp_1, (object) 2);
	      clauses = PJScheme.list_ref ((object) temp_1, (object) 1);
	      {
		 object clause = null;
		 clause = PJScheme.car ((object) clauses);
		 if (true_q
		     (PJScheme.
		      eq_q_hat ((object) PJScheme.car_hat ((object) clause),
				(object) symbol ("else"))))
		   {
		      value_reg =
			 PJScheme.cons ((object) clause, (object) value_reg);
		      k_reg = k;
		      pc = (Function) apply_cont;

		   }
		 else
		    if (true_q
			(PJScheme.
			 symbol_q_hat ((object) PJScheme.
				       car_hat ((object) clause))))
		   {
		      value_reg =
			 PJScheme.cons ((object) PJScheme.
					append ((object) PJScheme.
						list ((object) PJScheme.
						      append ((object)
							      PJScheme.
							      list ((object)
								    symbol
								    ("eq?")),
							      (object)
							      PJScheme.
							      append ((object)
								      PJScheme.
								      list ((object) var), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("quote")), (object) PJScheme.list ((object) PJScheme.get_sexp ((object) PJScheme.car_hat ((object) clause)))))))), (object) PJScheme.cdr_hat ((object) clause)), (object) value_reg);
		      k_reg = k;
		      pc = (Function) apply_cont;

		   }
		 else
		   {
		      value_reg =
			 PJScheme.cons ((object) PJScheme.
					append ((object) PJScheme.
						list ((object) PJScheme.
						      append ((object)
							      PJScheme.
							      list ((object)
								    symbol
								    ("memq")),
							      (object)
							      PJScheme.
							      append ((object)
								      PJScheme.
								      list ((object) var), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("quote")), (object) PJScheme.list ((object) PJScheme.get_sexp ((object) PJScheme.car_hat ((object) clause)))))))), (object) PJScheme.cdr_hat ((object) clause)), (object) value_reg);
		      k_reg = k;
		      pc = (Function) apply_cont;

		   }
	      }
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-11>"))))
	   {
	      object transformer_name = null;
	      transformer_name =
		 PJScheme.list_ref ((object) temp_1, (object) 1);
	      throw new
		 Exception (format
			    (transformer_name + ": " +
			     "bad concrete syntax: ~a", value_reg));
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-12>"))))
	   {
	      object bodies = null;
	      object info = null;
	      object fail = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      fail = PJScheme.list_ref ((object) temp_1, (object) 3);
	      info = PJScheme.list_ref ((object) temp_1, (object) 2);
	      bodies = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q (PJScheme.list_q ((object) value_reg)))
		{
		   value2_reg = fail;
		   value1_reg =
		      PJScheme.lambda_aexp ((object) value_reg,
					    (object) bodies, (object) info);
		   k_reg = k;
		   pc = (Function) apply_cont2;

		}
	      else
		{
		   value2_reg = fail;
		   value1_reg =
		      PJScheme.mu_lambda_aexp ((object) PJScheme.
					       head ((object) value_reg),
					       (object) PJScheme.
					       last ((object) value_reg),
					       (object) bodies,
					       (object) info);
		   k_reg = k;
		   pc = (Function) apply_cont2;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-13>"))))
	   {
	      object aclauses = null;
	      object name = null;
	      object info = null;
	      object fail = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 5);
	      fail = PJScheme.list_ref ((object) temp_1, (object) 4);
	      info = PJScheme.list_ref ((object) temp_1, (object) 3);
	      name = PJScheme.list_ref ((object) temp_1, (object) 2);
	      aclauses = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value2_reg = fail;
	      value1_reg =
		 PJScheme.define_syntax_aexp ((object) name,
					      (object) value_reg,
					      (object) aclauses,
					      (object) info);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-14>"))))
	   {
	      object info = null;
	      object handler = null;
	      object fail = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      fail = PJScheme.list_ref ((object) temp_1, (object) 3);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 2);
	      info = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg = k;
	      fail_reg = fail;
	      handler_reg = handler;
	      adatum_reg =
		 PJScheme.replace_info ((object) value_reg, (object) info);
	      pc = (Function) aparse;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-15>"))))
	   {
	      object info = null;
	      object handler = null;
	      object fail = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      fail = PJScheme.list_ref ((object) temp_1, (object) 3);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 2);
	      info = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont ((object) symbol ("<cont-14>"),
				     (object) info, (object) handler,
				     (object) fail, (object) k);
	      x_reg = value_reg;
	      pc = (Function) reannotate_cps;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-16>"))))
	   {
	      object adatum = null;
	      object handler = null;
	      object fail = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      fail = PJScheme.list_ref ((object) temp_1, (object) 3);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 2);
	      adatum = PJScheme.list_ref ((object) temp_1, (object) 1);
	      {
		 object info = null;
		 info = PJScheme.get_source_info ((object) adatum);
		 if (true_q
		     (PJScheme.original_source_info_q ((object) adatum)))
		   {
		      k_reg = k;
		      fail_reg = fail;
		      handler_reg = handler;
		      adatum_reg =
			 PJScheme.replace_info ((object) value_reg,
						(object) PJScheme.
						snoc ((object)
						      symbol ("quasiquote"),
						      (object) info));
		      pc = (Function) aparse;

		   }
		 else
		   {
		      k_reg = k;
		      fail_reg = fail;
		      handler_reg = handler;
		      adatum_reg =
			 PJScheme.replace_info ((object) value_reg,
						(object) info);
		      pc = (Function) aparse;

		   }
	      }
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-17>"))))
	   {
	      object adatum = null;
	      object handler = null;
	      object fail = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      fail = PJScheme.list_ref ((object) temp_1, (object) 3);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 2);
	      adatum = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont ((object) symbol ("<cont-16>"),
				     (object) adatum, (object) handler,
				     (object) fail, (object) k);
	      x_reg = value_reg;
	      pc = (Function) reannotate_cps;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-18>"))))
	   {
	      object info = null;
	      object fail = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      fail = PJScheme.list_ref ((object) temp_1, (object) 2);
	      info = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value2_reg = fail;
	      value1_reg =
		 PJScheme.lit_aexp ((object) value_reg, (object) info);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-19>"))))
	   {
	      object msg = null;
	      object info = null;
	      object handler = null;
	      object fail = null;
	      fail = PJScheme.list_ref ((object) temp_1, (object) 4);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 3);
	      info = PJScheme.list_ref ((object) temp_1, (object) 2);
	      msg = PJScheme.list_ref ((object) temp_1, (object) 1);
	      fail_reg = fail;
	      exception_reg =
		 PJScheme.format ((object) "parse error: ~a ~s ~a",
				  (object) msg, (object) value_reg,
				  (object) PJScheme.
				  where_at ((object) PJScheme.
					    get_start_line ((object) info),
					    (object) PJScheme.
					    get_start_char ((object) info),
					    (object) PJScheme.
					    get_srcfile ((object) info)));
	      handler_reg = handler;
	      pc = (Function) apply_handler2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-20>"))))
	   {
	      object adatum = null;
	      object fail = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      fail = PJScheme.list_ref ((object) temp_1, (object) 2);
	      adatum = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q (PJScheme.has_source_info_q ((object) value_reg)))
		{
		   value2_reg = fail;
		   value1_reg = value_reg;
		   k_reg = k;
		   pc = (Function) apply_cont2;

		}
	      else
		{
		   object info = null;
		   info = PJScheme.get_source_info ((object) adatum);
		   if (true_q
		       (PJScheme.original_source_info_q ((object) adatum)))
		     {
			object macro_keyword = null;
			macro_keyword =
			   PJScheme.get_sexp ((object) PJScheme.
					      car_hat ((object) adatum));
			value2_reg = fail;
			value1_reg =
			   PJScheme.replace_info ((object) value_reg,
						  (object) PJScheme.
						  snoc ((object)
							macro_keyword,
							(object) info));
			k_reg = k;
			pc = (Function) apply_cont2;
		     }
		   else
		     {
			value2_reg = fail;
			value1_reg =
			   PJScheme.replace_info ((object) value_reg,
						  (object) info);
			k_reg = k;
			pc = (Function) apply_cont2;

		     }
		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-21>"))))
	   {
	      object adatum = null;
	      object fail = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      fail = PJScheme.list_ref ((object) temp_1, (object) 2);
	      adatum = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont ((object) symbol ("<cont-20>"),
				     (object) adatum, (object) fail,
				     (object) k);
	      x_reg = value_reg;
	      pc = (Function) reannotate_cps;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-22>"))))
	   {
	      object aclauses = null;
	      object adatum = null;
	      object aright_pattern = null;
	      object clauses = null;
	      object right_pattern = null;
	      object handler = null;
	      object fail = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 8);
	      fail = PJScheme.list_ref ((object) temp_1, (object) 7);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 6);
	      right_pattern = PJScheme.list_ref ((object) temp_1, (object) 5);
	      clauses = PJScheme.list_ref ((object) temp_1, (object) 4);
	      aright_pattern =
		 PJScheme.list_ref ((object) temp_1, (object) 3);
	      adatum = PJScheme.list_ref ((object) temp_1, (object) 2);
	      aclauses = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q (value_reg))
		{
		   k2_reg =
		      PJScheme.make_cont2 ((object) symbol ("<cont2-39>"),
					   (object) fail, (object) k);
		   ap_reg = aright_pattern;
		   s_reg = value_reg;
		   pattern_reg = right_pattern;
		   pc = (Function) instantiate_hat;

		}
	      else
		{
		   k_reg = k;
		   fail_reg = fail;
		   handler_reg = handler;
		   adatum_reg = adatum;
		   aclauses_reg = PJScheme.cdr ((object) aclauses);
		   clauses_reg = PJScheme.cdr ((object) clauses);
		   pc = (Function) process_macro_clauses_hat;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-23>"))))
	   {
	      object aclauses = null;
	      object adatum = null;
	      object aleft_pattern = null;
	      object aright_pattern = null;
	      object clauses = null;
	      object left_pattern = null;
	      object right_pattern = null;
	      object handler = null;
	      object fail = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 10);
	      fail = PJScheme.list_ref ((object) temp_1, (object) 9);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 8);
	      right_pattern = PJScheme.list_ref ((object) temp_1, (object) 7);
	      left_pattern = PJScheme.list_ref ((object) temp_1, (object) 6);
	      clauses = PJScheme.list_ref ((object) temp_1, (object) 5);
	      aright_pattern =
		 PJScheme.list_ref ((object) temp_1, (object) 4);
	      aleft_pattern = PJScheme.list_ref ((object) temp_1, (object) 3);
	      adatum = PJScheme.list_ref ((object) temp_1, (object) 2);
	      aclauses = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont ((object) symbol ("<cont-22>"),
				     (object) aclauses, (object) adatum,
				     (object) aright_pattern,
				     (object) clauses, (object) right_pattern,
				     (object) handler, (object) fail,
				     (object) k);
	      ap2_reg = adatum;
	      ap1_reg = aleft_pattern;
	      p2_reg = value_reg;
	      p1_reg = left_pattern;
	      pc = (Function) unify_patterns_hat;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-24>"))))
	   {
	      object v1 = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      v1 = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value_reg =
		 PJScheme.append ((object) PJScheme.
				  list ((object) symbol ("append")),
				  (object) PJScheme.append ((object) PJScheme.
							    list ((object)
								  v1),
							    (object) PJScheme.
							    list ((object)
								  value_reg)));
	      k_reg = k;
	      pc = (Function) apply_cont;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-25>"))))
	   {
	      object ax = null;
	      object depth = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      depth = PJScheme.list_ref ((object) temp_1, (object) 2);
	      ax = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont ((object) symbol ("<cont-24>"),
				     (object) value_reg, (object) k);
	      depth_reg = depth;
	      ax_reg = PJScheme._hatcdr_hat ((object) ax);
	      pc = (Function) qq_expand_cps;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-26>"))))
	   {
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value_reg =
		 PJScheme.append ((object) PJScheme.
				  list ((object) symbol ("list->vector")),
				  (object) PJScheme.
				  list ((object) value_reg));
	      k_reg = k;
	      pc = (Function) apply_cont;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-27>"))))
	   {
	      object ax = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      ax = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value_reg =
		 PJScheme.append ((object) PJScheme.
				  list ((object) symbol ("cons")),
				  (object) PJScheme.append ((object) PJScheme.
							    list ((object)
								  PJScheme.
								  append ((object) PJScheme.list ((object) symbol ("quote")), (object) PJScheme.list ((object) PJScheme.car_hat ((object) ax)))), (object) PJScheme.list ((object) value_reg)));
	      k_reg = k;
	      pc = (Function) apply_cont;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-28>"))))
	   {
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value_reg =
		 PJScheme.append ((object) PJScheme.
				  list ((object) symbol ("cons")),
				  (object) PJScheme.append ((object) PJScheme.
							    list ((object)
								  PJScheme.
								  append ((object) PJScheme.list ((object) symbol ("quote")), (object) PJScheme.list ((object) symbol ("quasiquote")))), (object) PJScheme.list ((object) value_reg)));
	      k_reg = k;
	      pc = (Function) apply_cont;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-29>"))))
	   {
	      object v1 = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      v1 = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value_reg =
		 PJScheme.append ((object) PJScheme.
				  list ((object) symbol ("list")),
				  (object) PJScheme.list ((object) PJScheme.
							  append ((object)
								  PJScheme.
								  list ((object) symbol ("append")), (object) PJScheme.append ((object) PJScheme.list ((object) v1), (object) PJScheme.list ((object) value_reg)))));
	      k_reg = k;
	      pc = (Function) apply_cont;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-30>"))))
	   {
	      object ax = null;
	      object depth = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      depth = PJScheme.list_ref ((object) temp_1, (object) 2);
	      ax = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont ((object) symbol ("<cont-29>"),
				     (object) value_reg, (object) k);
	      depth_reg = depth;
	      ax_reg = PJScheme._hatcdr_hat ((object) ax);
	      pc = (Function) qq_expand_cps;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-31>"))))
	   {
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value_reg =
		 PJScheme.append ((object) PJScheme.
				  list ((object) symbol ("list")),
				  (object) PJScheme.
				  list ((object) value_reg));
	      k_reg = k;
	      pc = (Function) apply_cont;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-32>"))))
	   {
	      object ax = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      ax = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value_reg =
		 PJScheme.append ((object) PJScheme.
				  list ((object) symbol ("list")),
				  (object) PJScheme.list ((object) PJScheme.
							  append ((object)
								  PJScheme.
								  list ((object) symbol ("cons")), (object) PJScheme.append ((object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("quote")), (object) PJScheme.list ((object) PJScheme.car_hat ((object) ax)))), (object) PJScheme.list ((object) value_reg)))));
	      k_reg = k;
	      pc = (Function) apply_cont;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-33>"))))
	   {
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value_reg =
		 PJScheme.append ((object) PJScheme.
				  list ((object) symbol ("list")),
				  (object) PJScheme.list ((object) PJScheme.
							  append ((object)
								  PJScheme.
								  list ((object) symbol ("cons")), (object) PJScheme.append ((object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("quote")), (object) PJScheme.list ((object) symbol ("quasiquote")))), (object) PJScheme.list ((object) value_reg)))));
	      k_reg = k;
	      pc = (Function) apply_cont;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-34>"))))
	   {
	      object handler = null;
	      object fail = null;
	      object k2 = null;
	      k2 = PJScheme.list_ref ((object) temp_1, (object) 3);
	      fail = PJScheme.list_ref ((object) temp_1, (object) 2);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-70>"),
				      (object) handler, (object) k2);
	      fail_reg = fail;
	      handler_reg = handler;
	      adatum_reg = value_reg;
	      pc = (Function) aparse;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-35>"))))
	   {
	      object handler = null;
	      object fail = null;
	      object k2 = null;
	      k2 = PJScheme.list_ref ((object) temp_1, (object) 3);
	      fail = PJScheme.list_ref ((object) temp_1, (object) 2);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg = k2;
	      fail_reg = fail;
	      handler_reg = handler;
	      adatum_reg = value_reg;
	      pc = (Function) aparse;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-36>"))))
	   {
	      object fail = null;
	      object k2 = null;
	      k2 = PJScheme.list_ref ((object) temp_1, (object) 2);
	      fail = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value2_reg = fail;
	      value1_reg = value_reg;
	      k_reg = k2;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-37>"))))
	   {
	      object x = null;
	      object y = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      y = PJScheme.list_ref ((object) temp_1, (object) 2);
	      x = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q (value_reg))
		{
		   k_reg = k;
		   y_reg = PJScheme.cdr ((object) y);
		   x_reg = PJScheme.cdr ((object) x);
		   pc = (Function) equal_objects_q;

		}
	      else
		{
		   value_reg = false;
		   k_reg = k;
		   pc = (Function) apply_cont;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-38>"))))
	   {
	      object i = null;
	      object v1 = null;
	      object v2 = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      v2 = PJScheme.list_ref ((object) temp_1, (object) 3);
	      v1 = PJScheme.list_ref ((object) temp_1, (object) 2);
	      i = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q (value_reg))
		{
		   k_reg = k;
		   i_reg = PJScheme.Subtract ((object) i, (object) 1);
		   v2_reg = v2;
		   v1_reg = v1;
		   pc = (Function) equal_vectors_q;

		}
	      else
		{
		   value_reg = false;
		   k_reg = k;
		   pc = (Function) apply_cont;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-39>"))))
	   {
	      object ls = null;
	      object x = null;
	      object y = null;
	      object info = null;
	      object handler = null;
	      object fail = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 7);
	      fail = PJScheme.list_ref ((object) temp_1, (object) 6);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 5);
	      info = PJScheme.list_ref ((object) temp_1, (object) 4);
	      y = PJScheme.list_ref ((object) temp_1, (object) 3);
	      x = PJScheme.list_ref ((object) temp_1, (object) 2);
	      ls = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q (value_reg))
		{
		   value2_reg = fail;
		   value1_reg = y;
		   k_reg = k;
		   pc = (Function) apply_cont2;

		}
	      else
		{
		   k_reg = k;
		   fail_reg = fail;
		   handler_reg = handler;
		   info_reg = info;
		   ls_reg = ls;
		   y_reg = PJScheme.cdr ((object) y);
		   x_reg = x;
		   pc = (Function) member_loop;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-40>"))))
	   {
	      object ls1 = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      ls1 = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value_reg =
		 PJScheme.cons ((object) PJScheme.car ((object) ls1),
				(object) value_reg);
	      k_reg = k;
	      pc = (Function) apply_cont;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-41>"))))
	   {
	      object lists = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      lists = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg = k;
	      ls2_reg = value_reg;
	      ls1_reg = PJScheme.car ((object) lists);
	      pc = (Function) append2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-42>"))))
	   {
	      object pattern = null;
	      object var = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      var = PJScheme.list_ref ((object) temp_1, (object) 2);
	      pattern = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q (value_reg))
		{
		   value_reg = true;
		   k_reg = k;
		   pc = (Function) apply_cont;

		}
	      else
		{
		   k_reg = k;
		   pattern_reg = PJScheme.cdr ((object) pattern);
		   var_reg = var;
		   pc = (Function) occurs_q;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-43>"))))
	   {
	      object ap2 = null;
	      object p1 = null;
	      object p2 = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      p2 = PJScheme.list_ref ((object) temp_1, (object) 3);
	      p1 = PJScheme.list_ref ((object) temp_1, (object) 2);
	      ap2 = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q (value_reg))
		{
		   value_reg = false;
		   k_reg = k;
		   pc = (Function) apply_cont;

		}
	      else
		{
		   value_reg =
		      PJScheme.make_sub ((object) symbol ("unit"),
					 (object) p1, (object) p2,
					 (object) ap2);
		   k_reg = k;
		   pc = (Function) apply_cont;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-44>"))))
	   {
	      object s_car = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      s_car = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q (PJScheme.not ((object) value_reg)))
		{
		   value_reg = false;
		   k_reg = k;
		   pc = (Function) apply_cont;

		}
	      else
		{
		   value_reg =
		      PJScheme.make_sub ((object) symbol ("composite"),
					 (object) s_car, (object) value_reg);
		   k_reg = k;
		   pc = (Function) apply_cont;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont-45>"))))
	   {
	      object apair1 = null;
	      object apair2 = null;
	      object pair1 = null;
	      object pair2 = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 5);
	      pair2 = PJScheme.list_ref ((object) temp_1, (object) 4);
	      pair1 = PJScheme.list_ref ((object) temp_1, (object) 3);
	      apair2 = PJScheme.list_ref ((object) temp_1, (object) 2);
	      apair1 = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q (PJScheme.not ((object) value_reg)))
		{
		   value_reg = false;
		   k_reg = k;
		   pc = (Function) apply_cont;

		}
	      else
		{
		   k2_reg =
		      PJScheme.make_cont2 ((object) symbol ("<cont2-88>"),
					   (object) apair2, (object) pair2,
					   (object) value_reg, (object) k);
		   ap_reg = PJScheme._hatcdr_hat ((object) apair1);
		   s_reg = value_reg;
		   pattern_reg = PJScheme.cdr ((object) pair1);
		   pc = (Function) instantiate_hat;

		}
	   }
	 else
	    throw new
	       Exception (format
			  (symbol ("apply-cont") + ": " +
			   "bad continuation: ~a", k_reg));
      }

   }

   new public static object make_cont2 (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("continuation2"), (object) args));
   }

   new public static void apply_cont2 ()
   {
      {
	 object temp_1 = null;
	 temp_1 = PJScheme.cdr ((object) k_reg);
	 if (true_q
	     (PJScheme.
	      Eq ((object) PJScheme.car ((object) temp_1),
		  (object) symbol ("<cont2-1>"))))
	   {
	      object token = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      token = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg =
		 PJScheme.cons ((object) token, (object) value1_reg);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-2>"))))
	   {
	      final_reg = value1_reg;
	      pc = null;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-3>"))))
	   {
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg = PJScheme.binding_value ((object) value1_reg);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-4>"))))
	   {
	      object var_info = null;
	      object variable = null;
	      object env = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 5);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 4);
	      env = PJScheme.list_ref ((object) temp_1, (object) 3);
	      variable = PJScheme.list_ref ((object) temp_1, (object) 2);
	      var_info = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q (PJScheme.dlr_env_contains ((object) variable)))
		{
		   value1_reg = PJScheme.dlr_env_lookup ((object) variable);
		   k_reg = k;
		   pc = (Function) apply_cont2;

		}
	      else if (true_q (value1_reg))
		{
		   k_reg = k;
		   fail_reg = value2_reg;
		   handler_reg = handler;
		   env_reg = env;
		   path_reg = "";
		   components_reg = value1_reg;
		   pc = (Function) lookup_variable_components;

		}
	      else
		{
		   fail_reg = value2_reg;
		   handler_reg = handler;
		   info_reg = var_info;
		   msg_reg =
		      PJScheme.format ((object) "unbound variable ~a",
				       (object) variable);
		   pc = (Function) runtime_error;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-5>"))))
	   {
	      object components = null;
	      object path = null;
	      object var = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 5);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 4);
	      var = PJScheme.list_ref ((object) temp_1, (object) 3);
	      path = PJScheme.list_ref ((object) temp_1, (object) 2);
	      components = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q
		  (PJScheme.
		   null_q ((object) PJScheme.cdr ((object) components))))
		{
		   k_reg = k;
		   pc = (Function) apply_cont2;

		}
	      else
		{
		   object result = null;
		   object new_path = null;
		   new_path =
		      ((PJScheme.
			string_is__q ((object) path,
				      (object) "")) ? (PJScheme.
						       format ((object) "~a",
							       (object) var))
		       : (PJScheme.
			  format ((object) "~a.~a", (object) path,
				  (object) var)));
		   result = PJScheme.binding_value ((object) value1_reg);
		   if (true_q
		       (PJScheme.
			not ((object) PJScheme.
			     environment_q ((object) result))))
		      if (true_q (PJScheme.dlr_object_q ((object) result)))
			{
			   value1_reg =
			      PJScheme.dlr_lookup_components ((object) result,
							      (object)
							      PJScheme.
							      cdr ((object)
								   components));
			   k_reg = k;
			   pc = (Function) apply_cont2;

			}
		      else
			{
			   fail_reg = value2_reg;
			   exception_reg =
			      PJScheme.format ((object) "~a is not a module",
					       (object) new_path);
			   handler_reg = handler;
			   pc = (Function) apply_handler2;

			}
		   else
		     {
			k_reg = k;
			fail_reg = value2_reg;
			handler_reg = handler;
			env_reg = result;
			path_reg = new_path;
			components_reg = PJScheme.cdr ((object) components);
			pc = (Function) lookup_variable_components;

		     }
		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-6>"))))
	   {
	      object bodies = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      bodies = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value_reg =
		 PJScheme.append ((object) PJScheme.
				  list ((object) symbol ("let")),
				  (object) PJScheme.append ((object) PJScheme.
							    list ((object)
								  value1_reg),
							    (object) PJScheme.
							    append ((object)
								    value2_reg,
								    (object)
								    bodies)));
	      k_reg = k;
	      pc = (Function) apply_cont;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-7>"))))
	   {
	      object procs = null;
	      object vars = null;
	      object k2 = null;
	      k2 = PJScheme.list_ref ((object) temp_1, (object) 3);
	      vars = PJScheme.list_ref ((object) temp_1, (object) 2);
	      procs = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value2_reg =
		 PJScheme.cons ((object) PJScheme.
				append ((object) PJScheme.
					list ((object) symbol ("set!")),
					(object) PJScheme.
					append ((object) PJScheme.
						list ((object) PJScheme.
						      car ((object) vars)),
						(object) PJScheme.
						list ((object) PJScheme.
						      car ((object) procs)))),
				(object) value2_reg);
	      value1_reg =
		 PJScheme.cons ((object) PJScheme.
				append ((object) PJScheme.
					list ((object) PJScheme.
					      car ((object) vars)),
					(object) PJScheme.
					list ((object) PJScheme.
					      append ((object) PJScheme.
						      list ((object)
							    symbol ("quote")),
						      (object) PJScheme.
						      list ((object)
							    symbol
							    ("undefined"))))),
				(object) value1_reg);
	      k_reg = k2;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-8>"))))
	   {
	      object exp = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      exp = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value_reg =
		 PJScheme.append ((object) PJScheme.
				  list ((object) symbol ("let")),
				  (object) PJScheme.append ((object) PJScheme.
							    list ((object)
								  PJScheme.
								  append ((object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("r")), (object) PJScheme.list ((object) exp))), (object) value1_reg)), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("cond")), (object) value2_reg))));
	      k_reg = k;
	      pc = (Function) apply_cont;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-9>"))))
	   {
	      object clauses = null;
	      object var = null;
	      object k2 = null;
	      k2 = PJScheme.list_ref ((object) temp_1, (object) 3);
	      var = PJScheme.list_ref ((object) temp_1, (object) 2);
	      clauses = PJScheme.list_ref ((object) temp_1, (object) 1);
	      {
		 object clause = null;
		 clause = PJScheme.car ((object) clauses);
		 if (true_q
		     (PJScheme.
		      eq_q_hat ((object) PJScheme.car_hat ((object) clause),
				(object) symbol ("else"))))
		   {
		      value2_reg =
			 PJScheme.cons ((object) PJScheme.
					list ((object) symbol ("else"),
					      (object) PJScheme.
					      list ((object)
						    symbol ("else-code"))),
					(object) value2_reg);
		      value1_reg =
			 PJScheme.cons ((object) PJScheme.
					append ((object) PJScheme.
						list ((object)
						      symbol ("else-code")),
						(object) PJScheme.
						list ((object) PJScheme.
						      append ((object)
							      PJScheme.
							      list ((object)
								    symbol
								    ("lambda")),
							      (object)
							      PJScheme.
							      append ((object)
								      PJScheme.
								      list ((object) EmptyList), (object) PJScheme.cdr_hat ((object) clause))))), (object) value1_reg);
		      k_reg = k2;
		      pc = (Function) apply_cont2;

		   }
		 else
		    if (true_q
			(PJScheme.
			 symbol_q_hat ((object) PJScheme.
				       car_hat ((object) clause))))
		   {
		      object name = null;
		      name =
			 PJScheme.get_sexp ((object) PJScheme.
					    car_hat ((object) clause));
		      value2_reg =
			 PJScheme.cons ((object) PJScheme.
					append ((object) PJScheme.
						list ((object) PJScheme.
						      append ((object)
							      PJScheme.
							      list ((object)
								    symbol
								    ("eq?")),
							      (object)
							      PJScheme.
							      append ((object)
								      PJScheme.
								      list ((object) var), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("quote")), (object) PJScheme.list ((object) PJScheme.car_hat ((object) clause))))))), (object) PJScheme.list ((object) PJScheme.list ((object) name))), (object) value2_reg);
		      value1_reg =
			 PJScheme.cons ((object) PJScheme.
					append ((object) PJScheme.
						list ((object) name),
						(object) PJScheme.
						list ((object) PJScheme.
						      append ((object)
							      PJScheme.
							      list ((object)
								    symbol
								    ("lambda")),
							      (object)
							      PJScheme.
							      append ((object)
								      PJScheme.
								      list ((object) EmptyList), (object) PJScheme.cdr_hat ((object) clause))))), (object) value1_reg);
		      k_reg = k2;
		      pc = (Function) apply_cont2;
		   }
		 else
		   {
		      object name = null;
		      name =
			 PJScheme.get_sexp ((object) PJScheme.
					    car_hat ((object) PJScheme.
						     car_hat ((object)
							      clause)));
		      value2_reg =
			 PJScheme.cons ((object) PJScheme.
					append ((object) PJScheme.
						list ((object) PJScheme.
						      append ((object)
							      PJScheme.
							      list ((object)
								    symbol
								    ("memq")),
							      (object)
							      PJScheme.
							      append ((object)
								      PJScheme.
								      list ((object) var), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("quote")), (object) PJScheme.list ((object) PJScheme.car_hat ((object) clause))))))), (object) PJScheme.list ((object) PJScheme.list ((object) name))), (object) value2_reg);
		      value1_reg =
			 PJScheme.cons ((object) PJScheme.
					append ((object) PJScheme.
						list ((object) name),
						(object) PJScheme.
						list ((object) PJScheme.
						      append ((object)
							      PJScheme.
							      list ((object)
								    symbol
								    ("lambda")),
							      (object)
							      PJScheme.
							      append ((object)
								      PJScheme.
								      list ((object) EmptyList), (object) PJScheme.cdr_hat ((object) clause))))), (object) value1_reg);
		      k_reg = k2;
		      pc = (Function) apply_cont2;
		   }
	      }
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-10>"))))
	   {
	      object clauses = null;
	      object var = null;
	      object k2 = null;
	      k2 = PJScheme.list_ref ((object) temp_1, (object) 3);
	      var = PJScheme.list_ref ((object) temp_1, (object) 2);
	      clauses = PJScheme.list_ref ((object) temp_1, (object) 1);
	      {
		 object clause = null;
		 clause = PJScheme.car ((object) clauses);
		 if (true_q
		     (PJScheme.
		      eq_q_hat ((object) PJScheme.car_hat ((object) clause),
				(object) symbol ("else"))))
		   {
		      value2_reg =
			 PJScheme.cons ((object) PJScheme.
					append ((object) PJScheme.
						list ((object)
						      symbol ("else")),
						(object) PJScheme.
						list ((object) PJScheme.
						      list ((object)
							    symbol
							    ("else-code")))),
					(object) value2_reg);
		      value1_reg =
			 PJScheme.cons ((object) PJScheme.
					append ((object) PJScheme.
						list ((object)
						      symbol ("else-code")),
						(object) PJScheme.
						list ((object) PJScheme.
						      append ((object)
							      PJScheme.
							      list ((object)
								    symbol
								    ("lambda")),
							      (object)
							      PJScheme.
							      append ((object)
								      PJScheme.
								      list ((object) EmptyList), (object) PJScheme.cdr_hat ((object) clause))))), (object) value1_reg);
		      k_reg = k2;
		      pc = (Function) apply_cont2;

		   }
		 else
		    if (true_q
			(PJScheme.
			 symbol_q_hat ((object) PJScheme.
				       car_hat ((object) clause))))
		   {
		      object name = null;
		      name =
			 PJScheme.get_sexp ((object) PJScheme.
					    car_hat ((object) clause));
		      value2_reg =
			 PJScheme.cons ((object) PJScheme.
					append ((object) PJScheme.
						list ((object) PJScheme.
						      append ((object)
							      PJScheme.
							      list ((object)
								    symbol
								    ("eq?")),
							      (object)
							      PJScheme.
							      append ((object)
								      PJScheme.
								      list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("car")), (object) PJScheme.list ((object) var))), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("quote")), (object) PJScheme.list ((object) PJScheme.car_hat ((object) clause))))))), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("apply")), (object) PJScheme.append ((object) PJScheme.list ((object) name), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("cdr")), (object) PJScheme.list ((object) var))))))), (object) value2_reg);
		      value1_reg =
			 PJScheme.cons ((object) PJScheme.
					append ((object) PJScheme.
						list ((object) name),
						(object) PJScheme.
						list ((object) PJScheme.
						      append ((object)
							      PJScheme.
							      list ((object)
								    symbol
								    ("lambda")),
							      (object)
							      PJScheme.
							      append ((object)
								      PJScheme.
								      list ((object) PJScheme.cadr_hat ((object) clause)), (object) PJScheme.cddr_hat ((object) clause))))), (object) value1_reg);
		      k_reg = k2;
		      pc = (Function) apply_cont2;
		   }
		 else
		   {
		      object name = null;
		      name =
			 PJScheme.get_sexp ((object) PJScheme.
					    car_hat ((object) PJScheme.
						     car_hat ((object)
							      clause)));
		      value2_reg =
			 PJScheme.cons ((object) PJScheme.
					append ((object) PJScheme.
						list ((object) PJScheme.
						      append ((object)
							      PJScheme.
							      list ((object)
								    symbol
								    ("memq")),
							      (object)
							      PJScheme.
							      append ((object)
								      PJScheme.
								      list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("car")), (object) PJScheme.list ((object) var))), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("quote")), (object) PJScheme.list ((object) PJScheme.car_hat ((object) clause))))))), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("apply")), (object) PJScheme.append ((object) PJScheme.list ((object) name), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("cdr")), (object) PJScheme.list ((object) var))))))), (object) value2_reg);
		      value1_reg =
			 PJScheme.cons ((object) PJScheme.
					append ((object) PJScheme.
						list ((object) name),
						(object) PJScheme.
						list ((object) PJScheme.
						      append ((object)
							      PJScheme.
							      list ((object)
								    symbol
								    ("lambda")),
							      (object)
							      PJScheme.
							      append ((object)
								      PJScheme.
								      list ((object) PJScheme.cadr_hat ((object) clause)), (object) PJScheme.cddr_hat ((object) clause))))), (object) value1_reg);
		      k_reg = k2;
		      pc = (Function) apply_cont2;
		   }
	      }
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-11>"))))
	   {
	      object exp = null;
	      object type_name = null;
	      object type_tester_name = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      type_tester_name =
		 PJScheme.list_ref ((object) temp_1, (object) 3);
	      type_name = PJScheme.list_ref ((object) temp_1, (object) 2);
	      exp = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value_reg =
		 PJScheme.append ((object) PJScheme.
				  list ((object) symbol ("let")),
				  (object) PJScheme.append ((object) PJScheme.
							    list ((object)
								  PJScheme.
								  append ((object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("r")), (object) PJScheme.list ((object) exp))), (object) value1_reg)), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("if")), (object) PJScheme.append ((object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("not")), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) type_tester_name), (object) PJScheme.list ((object) symbol ("r")))))), (object) PJScheme.append ((object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("error")), (object) PJScheme.append ((object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("quote")), (object) PJScheme.list ((object) symbol ("cases")))), (object) PJScheme.append ((object) PJScheme.list ((object) "~a is not a valid ~a"), (object) PJScheme.append ((object) PJScheme.list ((object) symbol ("r")), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("quote")), (object) PJScheme.list ((object) type_name)))))))), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("cond")), (object) value2_reg))))))));
	      k_reg = k;
	      pc = (Function) apply_cont;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-12>"))))
	   {
	      object v1 = null;
	      object info = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      info = PJScheme.list_ref ((object) temp_1, (object) 2);
	      v1 = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg =
		 PJScheme.app_aexp ((object) v1, (object) value1_reg,
				    (object) info);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-13>"))))
	   {
	      object adatum = null;
	      object info = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 3);
	      info = PJScheme.list_ref ((object) temp_1, (object) 2);
	      adatum = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-12>"),
				      (object) value1_reg, (object) info,
				      (object) k);
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      adatum_list_reg = PJScheme.cdr_hat ((object) adatum);
	      pc = (Function) aparse_all;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-14>"))))
	   {
	      object info = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      info = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg =
		 PJScheme.choose_aexp ((object) value1_reg, (object) info);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-15>"))))
	   {
	      object info = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      info = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg =
		 PJScheme.dict_aexp ((object) value1_reg, (object) info);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-16>"))))
	   {
	      object info = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      info = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg =
		 PJScheme.raise_aexp ((object) value1_reg, (object) info);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-17>"))))
	   {
	      object adatum = null;
	      object cexps = null;
	      object body = null;
	      object info = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 5);
	      info = PJScheme.list_ref ((object) temp_1, (object) 4);
	      body = PJScheme.list_ref ((object) temp_1, (object) 3);
	      cexps = PJScheme.list_ref ((object) temp_1, (object) 2);
	      adatum = PJScheme.list_ref ((object) temp_1, (object) 1);
	      {
		 object cvar = null;
		 cvar =
		    PJScheme.get_sexp ((object) PJScheme.
				       catch_var_hat ((object) PJScheme.
						      caddr_hat ((object)
								 adatum)));
		 value1_reg =
		    PJScheme.try_catch_finally_aexp ((object) body,
						     (object) cvar,
						     (object) cexps,
						     (object) value1_reg,
						     (object) info);
		 k_reg = k;
		 pc = (Function) apply_cont2;
	      }
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-18>"))))
	   {
	      object adatum = null;
	      object body = null;
	      object info = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 5);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 4);
	      info = PJScheme.list_ref ((object) temp_1, (object) 3);
	      body = PJScheme.list_ref ((object) temp_1, (object) 2);
	      adatum = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-17>"),
				      (object) adatum, (object) value1_reg,
				      (object) body, (object) info,
				      (object) k);
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      adatum_list_reg =
		 PJScheme.finally_exps_hat ((object) PJScheme.
					    cadddr_hat ((object) adatum));
	      pc = (Function) aparse_all;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-19>"))))
	   {
	      object adatum = null;
	      object info = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 3);
	      info = PJScheme.list_ref ((object) temp_1, (object) 2);
	      adatum = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-18>"),
				      (object) adatum, (object) value1_reg,
				      (object) info, (object) handler,
				      (object) k);
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      adatum_list_reg =
		 PJScheme.catch_exps_hat ((object) PJScheme.
					  caddr_hat ((object) adatum));
	      pc = (Function) aparse_all;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-20>"))))
	   {
	      object body = null;
	      object info = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      info = PJScheme.list_ref ((object) temp_1, (object) 2);
	      body = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg =
		 PJScheme.try_finally_aexp ((object) body,
					    (object) value1_reg,
					    (object) info);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-21>"))))
	   {
	      object adatum = null;
	      object info = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 3);
	      info = PJScheme.list_ref ((object) temp_1, (object) 2);
	      adatum = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-20>"),
				      (object) value1_reg, (object) info,
				      (object) k);
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      adatum_list_reg =
		 PJScheme.finally_exps_hat ((object) PJScheme.
					    caddr_hat ((object) adatum));
	      pc = (Function) aparse_all;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-22>"))))
	   {
	      object adatum = null;
	      object body = null;
	      object info = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      info = PJScheme.list_ref ((object) temp_1, (object) 3);
	      body = PJScheme.list_ref ((object) temp_1, (object) 2);
	      adatum = PJScheme.list_ref ((object) temp_1, (object) 1);
	      {
		 object cvar = null;
		 cvar =
		    PJScheme.get_sexp ((object) PJScheme.
				       catch_var_hat ((object) PJScheme.
						      caddr_hat ((object)
								 adatum)));
		 value1_reg =
		    PJScheme.try_catch_aexp ((object) body, (object) cvar,
					     (object) value1_reg,
					     (object) info);
		 k_reg = k;
		 pc = (Function) apply_cont2;
	      }
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-23>"))))
	   {
	      object adatum = null;
	      object info = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 3);
	      info = PJScheme.list_ref ((object) temp_1, (object) 2);
	      adatum = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-22>"),
				      (object) adatum, (object) value1_reg,
				      (object) info, (object) k);
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      adatum_list_reg =
		 PJScheme.catch_exps_hat ((object) PJScheme.
					  caddr_hat ((object) adatum));
	      pc = (Function) aparse_all;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-24>"))))
	   {
	      object adatum = null;
	      object info = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      info = PJScheme.list_ref ((object) temp_1, (object) 2);
	      adatum = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont ((object) symbol ("<cont-12>"),
				     (object) value1_reg, (object) info,
				     (object) value2_reg, (object) k);
	      x_reg = PJScheme.cadr_hat ((object) adatum);
	      pc = (Function) unannotate_cps;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-25>"))))
	   {
	      object adatum = null;
	      object info = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 3);
	      info = PJScheme.list_ref ((object) temp_1, (object) 2);
	      adatum = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q (PJScheme.null_q ((object) value1_reg)))
		{
		   fail_reg = value2_reg;
		   handler_reg = handler;
		   adatum_reg = adatum;
		   msg_reg = "bad concrete syntax:";
		   pc = (Function) aparse_error;

		}
	      else
		 if (true_q
		     (PJScheme.
		      null_q ((object) PJScheme.cdr ((object) value1_reg))))
		{
		   value1_reg = PJScheme.car ((object) value1_reg);
		   k_reg = k;
		   pc = (Function) apply_cont2;

		}
	      else
		{
		   value1_reg =
		      PJScheme.begin_aexp ((object) value1_reg,
					   (object) info);
		   k_reg = k;
		   pc = (Function) apply_cont2;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-26>"))))
	   {
	      object adatum = null;
	      object info = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      info = PJScheme.list_ref ((object) temp_1, (object) 2);
	      adatum = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg =
		 PJScheme.define_b_aexp ((object) PJScheme.
					 get_sexp ((object) PJScheme.
						   cadr_hat ((object)
							     adatum)),
					 (object) PJScheme.
					 get_sexp ((object) PJScheme.
						   caddr_hat ((object)
							      adatum)),
					 (object) value1_reg, (object) info);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-27>"))))
	   {
	      object adatum = null;
	      object info = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      info = PJScheme.list_ref ((object) temp_1, (object) 2);
	      adatum = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg =
		 PJScheme.define_b_aexp ((object) PJScheme.
					 get_sexp ((object) PJScheme.
						   cadr_hat ((object)
							     adatum)),
					 (object) "", (object) value1_reg,
					 (object) info);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-28>"))))
	   {
	      object adatum = null;
	      object info = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      info = PJScheme.list_ref ((object) temp_1, (object) 2);
	      adatum = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg =
		 PJScheme.define_aexp ((object) PJScheme.
				       get_sexp ((object) PJScheme.
						 cadr_hat ((object) adatum)),
				       (object) PJScheme.
				       get_sexp ((object) PJScheme.
						 caddr_hat ((object) adatum)),
				       (object) value1_reg, (object) info);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-29>"))))
	   {
	      object adatum = null;
	      object info = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      info = PJScheme.list_ref ((object) temp_1, (object) 2);
	      adatum = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg =
		 PJScheme.define_aexp ((object) PJScheme.
				       get_sexp ((object) PJScheme.
						 cadr_hat ((object) adatum)),
				       (object) "", (object) value1_reg,
				       (object) info);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-30>"))))
	   {
	      object info = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      info = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg =
		 PJScheme.func_aexp ((object) value1_reg, (object) info);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-31>"))))
	   {
	      object adatum = null;
	      object info = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      info = PJScheme.list_ref ((object) temp_1, (object) 2);
	      adatum = PJScheme.list_ref ((object) temp_1, (object) 1);
	      {
		 object var_info = null;
		 var_info =
		    PJScheme.get_source_info ((object) PJScheme.
					      cadr_hat ((object) adatum));
		 value1_reg =
		    PJScheme.assign_aexp ((object) PJScheme.
					  get_sexp ((object) PJScheme.
						    cadr_hat ((object)
							      adatum)),
					  (object) value1_reg,
					  (object) var_info, (object) info);
		 k_reg = k;
		 pc = (Function) apply_cont2;
	      }
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-32>"))))
	   {
	      object v1 = null;
	      object v2 = null;
	      object info = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      info = PJScheme.list_ref ((object) temp_1, (object) 3);
	      v2 = PJScheme.list_ref ((object) temp_1, (object) 2);
	      v1 = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg =
		 PJScheme.if_aexp ((object) v1, (object) v2,
				   (object) value1_reg, (object) info);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-33>"))))
	   {
	      object adatum = null;
	      object v1 = null;
	      object info = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 5);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 4);
	      info = PJScheme.list_ref ((object) temp_1, (object) 3);
	      v1 = PJScheme.list_ref ((object) temp_1, (object) 2);
	      adatum = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-32>"),
				      (object) v1, (object) value1_reg,
				      (object) info, (object) k);
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      adatum_reg = PJScheme.cadddr_hat ((object) adatum);
	      pc = (Function) aparse;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-34>"))))
	   {
	      object adatum = null;
	      object info = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 3);
	      info = PJScheme.list_ref ((object) temp_1, (object) 2);
	      adatum = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-33>"),
				      (object) adatum, (object) value1_reg,
				      (object) info, (object) handler,
				      (object) k);
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      adatum_reg = PJScheme.caddr_hat ((object) adatum);
	      pc = (Function) aparse;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-35>"))))
	   {
	      object v1 = null;
	      object info = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      info = PJScheme.list_ref ((object) temp_1, (object) 2);
	      v1 = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg =
		 PJScheme.if_aexp ((object) v1, (object) value1_reg,
				   (object) PJScheme.lit_aexp ((object) false,
							       (object)
							       symbol
							       ("none")),
				   (object) info);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-36>"))))
	   {
	      object adatum = null;
	      object info = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 3);
	      info = PJScheme.list_ref ((object) temp_1, (object) 2);
	      adatum = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-35>"),
				      (object) value1_reg, (object) info,
				      (object) k);
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      adatum_reg = PJScheme.caddr_hat ((object) adatum);
	      pc = (Function) aparse;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-37>"))))
	   {
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg = k;
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      adatum_reg = value1_reg;
	      pc = (Function) aparse;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-38>"))))
	   {
	      object adatum = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 2);
	      adatum = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q (PJScheme.pattern_macro_q ((object) value1_reg)))
		{
		   k_reg = k;
		   fail_reg = value2_reg;
		   handler_reg = handler;
		   adatum_reg = adatum;
		   aclauses_reg =
		      PJScheme.macro_aclauses_hat ((object) value1_reg);
		   clauses_reg =
		      PJScheme.macro_clauses_hat ((object) value1_reg);
		   pc = (Function) process_macro_clauses_hat;

		}
	      else
		{
		   k_reg =
		      PJScheme.make_cont ((object) symbol ("<cont-21>"),
					  (object) adatum,
					  (object) value2_reg, (object) k);
		   datum_reg = adatum;
		   macro_reg = value1_reg;
		   pc = (Function) apply_macro;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-39>"))))
	   {
	      object fail = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      fail = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg = value2_reg;
	      value2_reg = fail;
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-40>"))))
	   {
	      object a = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      a = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg = PJScheme.cons ((object) a, (object) value1_reg);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-41>"))))
	   {
	      object entries = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 2);
	      entries = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-40>"),
				      (object) value1_reg, (object) k);
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      entries_reg = PJScheme.cdr ((object) entries);
	      pc = (Function) aparse_entries;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-42>"))))
	   {
	      object adatum_list = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 2);
	      adatum_list = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-40>"),
				      (object) value1_reg, (object) k);
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      adatum_list_reg = PJScheme.cdr ((object) adatum_list);
	      pc = (Function) aparse_all;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-43>"))))
	   {
	      object exp = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      exp = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg = PJScheme.cons ((object) exp, (object) value1_reg);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-44>"))))
	   {
	      object src = null;
	      object tokens_left = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 3);
	      tokens_left = PJScheme.list_ref ((object) temp_1, (object) 2);
	      src = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-43>"),
				      (object) value1_reg, (object) k);
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      src_reg = src;
	      tokens_reg = tokens_left;
	      pc = (Function) aparse_sexps;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-45>"))))
	   {
	      _starlast_fail_star = value2_reg;
	      final_reg = value1_reg;
	      pc = null;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-46>"))))
	   {
	      k_reg = REP_k;
	      fail_reg = value2_reg;
	      handler_reg = REP_handler;
	      env_reg = toplevel_env;
	      exp_reg = value1_reg;
	      pc = (Function) m;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-47>"))))
	   {
	      final_reg = true;
	      pc = null;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-48>"))))
	   {
	      k_reg = PJScheme.make_cont2 ((object) symbol ("<cont2-47>"));
	      fail_reg = value2_reg;
	      handler_reg = try_parse_handler;
	      src_reg = symbol ("stdin");
	      tokens_reg = value1_reg;
	      pc = (Function) aparse_sexps;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-49>"))))
	   {
	      object src = null;
	      object tokens_left = null;
	      object env = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 5);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 4);
	      env = PJScheme.list_ref ((object) temp_1, (object) 3);
	      tokens_left = PJScheme.list_ref ((object) temp_1, (object) 2);
	      src = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q
		  (PJScheme.
		   token_type_q ((object) PJScheme.
				 first ((object) tokens_left),
				 (object) symbol ("end-marker"))))
		{
		   k_reg = k;
		   pc = (Function) apply_cont2;

		}
	      else
		{
		   k_reg = k;
		   fail_reg = value2_reg;
		   handler_reg = handler;
		   env_reg = env;
		   src_reg = src;
		   tokens_reg = tokens_left;
		   pc = (Function) read_and_eval_asexps;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-50>"))))
	   {
	      object src = null;
	      object tokens_left = null;
	      object env = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 5);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 4);
	      env = PJScheme.list_ref ((object) temp_1, (object) 3);
	      tokens_left = PJScheme.list_ref ((object) temp_1, (object) 2);
	      src = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-49>"),
				      (object) src, (object) tokens_left,
				      (object) env, (object) handler,
				      (object) k);
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      env_reg = env;
	      exp_reg = value1_reg;
	      pc = (Function) m;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-51>"))))
	   {
	      object exp = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      exp = PJScheme.list_ref ((object) temp_1, (object) 1);
	      PJScheme.handle_debug_info ((object) exp, (object) value1_reg);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-52>"))))
	   {
	      object args = null;
	      object env = null;
	      object info = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 5);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 4);
	      info = PJScheme.list_ref ((object) temp_1, (object) 3);
	      env = PJScheme.list_ref ((object) temp_1, (object) 2);
	      args = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q (PJScheme.dlr_exp_q ((object) value1_reg)))
		{
		   value1_reg =
		      PJScheme.dlr_apply ((object) value1_reg, (object) args);
		   k_reg = k;
		   pc = (Function) apply_cont2;

		}
	      else
		 if (true_q
		     (PJScheme.procedure_object_q ((object) value1_reg)))
		{
		   k2_reg = k;
		   fail_reg = value2_reg;
		   handler_reg = handler;
		   info_reg = info;
		   env2_reg = env;
		   args_reg = args;
		   proc_reg = value1_reg;
		   pc = (Function) apply_proc;

		}
	      else
		{
		   fail_reg = value2_reg;
		   handler_reg = handler;
		   info_reg = info;
		   msg_reg =
		      PJScheme.
		      format ((object) "attempt to apply non-procedure ~a",
			      (object) value1_reg);
		   pc = (Function) runtime_error;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-53>"))))
	   {
	      object rator = null;
	      object env = null;
	      object info = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 5);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 4);
	      info = PJScheme.list_ref ((object) temp_1, (object) 3);
	      env = PJScheme.list_ref ((object) temp_1, (object) 2);
	      rator = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-52>"),
				      (object) value1_reg, (object) env,
				      (object) info, (object) handler,
				      (object) k);
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      env_reg = env;
	      exp_reg = rator;
	      pc = (Function) m;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-54>"))))
	   {
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg = PJScheme.binding_docstring ((object) value1_reg);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-55>"))))
	   {
	      object handler = null;
	      handler = PJScheme.list_ref ((object) temp_1, (object) 1);
	      fail_reg = value2_reg;
	      exception_reg = value1_reg;
	      handler_reg = handler;
	      pc = (Function) apply_handler2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-56>"))))
	   {
	      object v = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      v = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg = v;
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-57>"))))
	   {
	      object fexps = null;
	      object env = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 3);
	      env = PJScheme.list_ref ((object) temp_1, (object) 2);
	      fexps = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-56>"),
				      (object) value1_reg, (object) k);
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      env_reg = env;
	      exps_reg = fexps;
	      pc = (Function) eval_sequence;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-58>"))))
	   {
	      object aclauses = null;
	      object clauses = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      clauses = PJScheme.list_ref ((object) temp_1, (object) 2);
	      aclauses = PJScheme.list_ref ((object) temp_1, (object) 1);
	      PJScheme.set_binding_value_b ((object) value1_reg,
					    (object) PJScheme.
					    make_pattern_macro_hat ((object)
								    clauses,
								    (object)
								    aclauses));
	      value1_reg = void_value;
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-59>"))))
	   {
	      object docstring = null;
	      object var = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      var = PJScheme.list_ref ((object) temp_1, (object) 2);
	      docstring = PJScheme.list_ref ((object) temp_1, (object) 1);
	      PJScheme.set_global_value_b ((object) var, (object) value1_reg);
	      PJScheme.set_global_docstring_b ((object) var,
					       (object) docstring);
	      value1_reg = void_value;
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-60>"))))
	   {
	      object docstring = null;
	      object rhs_value = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      rhs_value = PJScheme.list_ref ((object) temp_1, (object) 2);
	      docstring = PJScheme.list_ref ((object) temp_1, (object) 1);
	      PJScheme.set_binding_value_b ((object) value1_reg,
					    (object) rhs_value);
	      PJScheme.set_binding_docstring_b ((object) value1_reg,
						(object) docstring);
	      value1_reg = void_value;
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-61>"))))
	   {
	      object docstring = null;
	      object var = null;
	      object env = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 5);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 4);
	      env = PJScheme.list_ref ((object) temp_1, (object) 3);
	      var = PJScheme.list_ref ((object) temp_1, (object) 2);
	      docstring = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-60>"),
				      (object) docstring, (object) value1_reg,
				      (object) k);
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      env_reg = env;
	      var_reg = var;
	      pc = (Function) lookup_binding_in_first_frame;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-62>"))))
	   {
	      object rhs_value = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      rhs_value = PJScheme.list_ref ((object) temp_1, (object) 1);
	      {
		 object old_value = null;
		 old_value = PJScheme.binding_value ((object) value1_reg);
		 PJScheme.set_binding_value_b ((object) value1_reg,
					       (object) rhs_value);
		 {
		    object new_fail = null;
		    new_fail =
		       PJScheme.make_fail ((object) symbol ("<fail-2>"),
					   (object) value1_reg,
					   (object) old_value,
					   (object) value2_reg);
		    value2_reg = new_fail;
		    value1_reg = void_value;
		    k_reg = k;
		    pc = (Function) apply_cont2;
		 }
	      }
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-63>"))))
	   {
	      object var = null;
	      object var_info = null;
	      object env = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 5);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 4);
	      env = PJScheme.list_ref ((object) temp_1, (object) 3);
	      var_info = PJScheme.list_ref ((object) temp_1, (object) 2);
	      var = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-62>"),
				      (object) value1_reg, (object) k);
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      var_info_reg = var_info;
	      env_reg = env;
	      variable_reg = var;
	      pc = (Function) lookup_binding;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-64>"))))
	   {
	      object else_exp = null;
	      object then_exp = null;
	      object env = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 5);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 4);
	      env = PJScheme.list_ref ((object) temp_1, (object) 3);
	      then_exp = PJScheme.list_ref ((object) temp_1, (object) 2);
	      else_exp = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q (value1_reg))
		{
		   k_reg = k;
		   fail_reg = value2_reg;
		   handler_reg = handler;
		   env_reg = env;
		   exp_reg = then_exp;
		   pc = (Function) m;

		}
	      else
		{
		   k_reg = k;
		   fail_reg = value2_reg;
		   handler_reg = handler;
		   env_reg = env;
		   exp_reg = else_exp;
		   pc = (Function) m;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-65>"))))
	   {
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg = PJScheme.dlr_func ((object) value1_reg);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-66>"))))
	   {
	      object e = null;
	      object handler = null;
	      handler = PJScheme.list_ref ((object) temp_1, (object) 2);
	      e = PJScheme.list_ref ((object) temp_1, (object) 1);
	      fail_reg = value2_reg;
	      exception_reg = e;
	      handler_reg = handler;
	      pc = (Function) apply_handler2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-67>"))))
	   {
	      object v1 = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      v1 = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg = PJScheme.cons ((object) v1, (object) value1_reg);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-68>"))))
	   {
	      object exps = null;
	      object env = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 3);
	      env = PJScheme.list_ref ((object) temp_1, (object) 2);
	      exps = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-67>"),
				      (object) value1_reg, (object) k);
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      env_reg = env;
	      exps_reg = PJScheme.cdr ((object) exps);
	      pc = (Function) m_star;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-69>"))))
	   {
	      object exps = null;
	      object env = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 3);
	      env = PJScheme.list_ref ((object) temp_1, (object) 2);
	      exps = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q
		  (PJScheme.null_q ((object) PJScheme.cdr ((object) exps))))
		{
		   k_reg = k;
		   pc = (Function) apply_cont2;

		}
	      else
		{
		   k_reg = k;
		   fail_reg = value2_reg;
		   handler_reg = handler;
		   env_reg = env;
		   exps_reg = PJScheme.cdr ((object) exps);
		   pc = (Function) eval_sequence;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-70>"))))
	   {
	      object handler = null;
	      object k2 = null;
	      k2 = PJScheme.list_ref ((object) temp_1, (object) 2);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg = k2;
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      env_reg = toplevel_env;
	      exp_reg = value1_reg;
	      pc = (Function) m;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-71>"))))
	   {
	      object handler = null;
	      object k2 = null;
	      k2 = PJScheme.list_ref ((object) temp_1, (object) 2);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont4 ((object) symbol ("<cont4-11>"),
				      (object) handler, (object) k2);
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      src_reg = symbol ("stdin");
	      tokens_reg = value1_reg;
	      pc = (Function) read_asexp;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-72>"))))
	   {
	      object handler = null;
	      object k2 = null;
	      k2 = PJScheme.list_ref ((object) temp_1, (object) 2);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont4 ((object) symbol ("<cont4-12>"),
				      (object) handler, (object) k2);
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      src_reg = symbol ("stdin");
	      tokens_reg = value1_reg;
	      pc = (Function) read_asexp;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-73>"))))
	   {
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q (PJScheme.null_q ((object) load_stack)))
		 PJScheme.
		    printf ((object)
			    "WARNING: empty load-stack encountered!\n");
	      else
		 load_stack = PJScheme.cdr ((object) load_stack);
	      value1_reg = void_value;
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-74>"))))
	   {
	      object filename = null;
	      object env = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 3);
	      env = PJScheme.list_ref ((object) temp_1, (object) 2);
	      filename = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-73>"),
				      (object) k);
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      env_reg = env;
	      src_reg = filename;
	      tokens_reg = value1_reg;
	      pc = (Function) read_and_eval_asexps;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-75>"))))
	   {
	      object filenames = null;
	      object env = null;
	      object info = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 5);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 4);
	      info = PJScheme.list_ref ((object) temp_1, (object) 3);
	      env = PJScheme.list_ref ((object) temp_1, (object) 2);
	      filenames = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg = k;
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      info_reg = info;
	      env_reg = env;
	      filenames_reg = PJScheme.cdr ((object) filenames);
	      pc = (Function) load_files;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-76>"))))
	   {
	      object filename = null;
	      object env2 = null;
	      object handler = null;
	      object k2 = null;
	      k2 = PJScheme.list_ref ((object) temp_1, (object) 4);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 3);
	      env2 = PJScheme.list_ref ((object) temp_1, (object) 2);
	      filename = PJScheme.list_ref ((object) temp_1, (object) 1);
	      {
		 object module = null;
		 module =
		    PJScheme.extend ((object) env2, (object) EmptyList,
				     (object) EmptyList);
		 PJScheme.set_binding_value_b ((object) value1_reg,
					       (object) module);
		 k_reg = k2;
		 fail_reg = value2_reg;
		 handler_reg = handler;
		 info_reg = symbol ("none");
		 env_reg = module;
		 filename_reg = filename;
		 pc = (Function) load_file;
	      }
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-77>"))))
	   {
	      object args = null;
	      object sym = null;
	      object info = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 5);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 4);
	      info = PJScheme.list_ref ((object) temp_1, (object) 3);
	      sym = PJScheme.list_ref ((object) temp_1, (object) 2);
	      args = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q
		  (PJScheme.null_q ((object) PJScheme.cdr ((object) args))))
		{
		   k_reg = k;
		   pc = (Function) apply_cont2;

		}
	      else
		 if (true_q
		     (PJScheme.
		      not ((object) PJScheme.
			   environment_q ((object) value1_reg))))
		{
		   fail_reg = value2_reg;
		   handler_reg = handler;
		   info_reg = info;
		   msg_reg =
		      PJScheme.format ((object) "invalid module ~a",
				       (object) sym);
		   pc = (Function) runtime_error;

		}
	      else
		{
		   k_reg = k;
		   fail_reg = value2_reg;
		   handler_reg = handler;
		   info_reg = info;
		   env_reg = value1_reg;
		   args_reg = PJScheme.cdr ((object) args);
		   pc = (Function) get_primitive;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-78>"))))
	   {
	      object iterator = null;
	      object proc = null;
	      object env = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 5);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 4);
	      env = PJScheme.list_ref ((object) temp_1, (object) 3);
	      proc = PJScheme.list_ref ((object) temp_1, (object) 2);
	      iterator = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg = k;
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      env_reg = env;
	      iterator_reg = iterator;
	      proc_reg = proc;
	      pc = (Function) iterate_continue;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-79>"))))
	   {
	      object iterator = null;
	      object proc = null;
	      object env = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 5);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 4);
	      env = PJScheme.list_ref ((object) temp_1, (object) 3);
	      proc = PJScheme.list_ref ((object) temp_1, (object) 2);
	      iterator = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-67>"),
				      (object) value1_reg, (object) k);
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      env_reg = env;
	      iterator_reg = iterator;
	      proc_reg = proc;
	      pc = (Function) iterate_collect_continue;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-80>"))))
	   {
	      object list1 = null;
	      object proc = null;
	      object env = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 5);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 4);
	      env = PJScheme.list_ref ((object) temp_1, (object) 3);
	      proc = PJScheme.list_ref ((object) temp_1, (object) 2);
	      list1 = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-67>"),
				      (object) value1_reg, (object) k);
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      env_reg = env;
	      list1_reg = PJScheme.cdr ((object) list1);
	      proc_reg = proc;
	      pc = (Function) map1;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-81>"))))
	   {
	      object list1 = null;
	      object proc = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      proc = PJScheme.list_ref ((object) temp_1, (object) 2);
	      list1 = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg =
		 PJScheme.cons ((object) PJScheme.
				dlr_apply ((object) proc,
					   (object) PJScheme.
					   list ((object) PJScheme.
						 car ((object) list1))),
				(object) value1_reg);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-82>"))))
	   {
	      object list1 = null;
	      object list2 = null;
	      object proc = null;
	      object env = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 6);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 5);
	      env = PJScheme.list_ref ((object) temp_1, (object) 4);
	      proc = PJScheme.list_ref ((object) temp_1, (object) 3);
	      list2 = PJScheme.list_ref ((object) temp_1, (object) 2);
	      list1 = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-67>"),
				      (object) value1_reg, (object) k);
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      env_reg = env;
	      list2_reg = PJScheme.cdr ((object) list2);
	      list1_reg = PJScheme.cdr ((object) list1);
	      proc_reg = proc;
	      pc = (Function) map2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-83>"))))
	   {
	      object list1 = null;
	      object list2 = null;
	      object proc = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      proc = PJScheme.list_ref ((object) temp_1, (object) 3);
	      list2 = PJScheme.list_ref ((object) temp_1, (object) 2);
	      list1 = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg =
		 PJScheme.cons ((object) PJScheme.
				dlr_apply ((object) proc,
					   (object) PJScheme.
					   list ((object) PJScheme.
						 car ((object) list1),
						 (object) PJScheme.
						 car ((object) list2))),
				(object) value1_reg);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-84>"))))
	   {
	      object lists = null;
	      object proc = null;
	      object env = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 5);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 4);
	      env = PJScheme.list_ref ((object) temp_1, (object) 3);
	      proc = PJScheme.list_ref ((object) temp_1, (object) 2);
	      lists = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-67>"),
				      (object) value1_reg, (object) k);
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      env_reg = env;
	      lists_reg = map (cdr_proc, (object) lists);
	      proc_reg = proc;
	      pc = (Function) mapN;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-85>"))))
	   {
	      object lists = null;
	      object proc = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      proc = PJScheme.list_ref ((object) temp_1, (object) 2);
	      lists = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg =
		 PJScheme.cons ((object) PJScheme.
				dlr_apply ((object) proc,
					   (object) map (car_proc,
							 (object) lists)),
				(object) value1_reg);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-86>"))))
	   {
	      object arg_list = null;
	      object proc = null;
	      object env = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 5);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 4);
	      env = PJScheme.list_ref ((object) temp_1, (object) 3);
	      proc = PJScheme.list_ref ((object) temp_1, (object) 2);
	      arg_list = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg = k;
	      fail_reg = value2_reg;
	      handler_reg = handler;
	      env_reg = env;
	      lists_reg = map (cdr_proc, (object) arg_list);
	      proc_reg = proc;
	      pc = (Function) for_each_primitive;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-87>"))))
	   {
	      object new_acdr1 = null;
	      object new_cdr1 = null;
	      object s_car = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      s_car = PJScheme.list_ref ((object) temp_1, (object) 3);
	      new_cdr1 = PJScheme.list_ref ((object) temp_1, (object) 2);
	      new_acdr1 = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont ((object) symbol ("<cont-44>"),
				     (object) s_car, (object) k);
	      ap2_reg = value2_reg;
	      ap1_reg = new_acdr1;
	      p2_reg = value1_reg;
	      p1_reg = new_cdr1;
	      pc = (Function) unify_patterns_hat;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-88>"))))
	   {
	      object apair2 = null;
	      object pair2 = null;
	      object s_car = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      s_car = PJScheme.list_ref ((object) temp_1, (object) 3);
	      pair2 = PJScheme.list_ref ((object) temp_1, (object) 2);
	      apair2 = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k2_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-87>"),
				      (object) value2_reg,
				      (object) value1_reg, (object) s_car,
				      (object) k);
	      ap_reg = PJScheme._hatcdr_hat ((object) apair2);
	      s_reg = s_car;
	      pattern_reg = PJScheme.cdr ((object) pair2);
	      pc = (Function) instantiate_hat;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-89>"))))
	   {
	      object a = null;
	      object aa = null;
	      object ap = null;
	      object k2 = null;
	      k2 = PJScheme.list_ref ((object) temp_1, (object) 4);
	      ap = PJScheme.list_ref ((object) temp_1, (object) 3);
	      aa = PJScheme.list_ref ((object) temp_1, (object) 2);
	      a = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value2_reg =
		 PJScheme.cons_hat ((object) aa, (object) value2_reg,
				    (object) PJScheme.
				    get_source_info ((object) ap));
	      value1_reg = PJScheme.cons ((object) a, (object) value1_reg);
	      k_reg = k2;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-90>"))))
	   {
	      object ap = null;
	      object pattern = null;
	      object s = null;
	      object k2 = null;
	      k2 = PJScheme.list_ref ((object) temp_1, (object) 4);
	      s = PJScheme.list_ref ((object) temp_1, (object) 3);
	      pattern = PJScheme.list_ref ((object) temp_1, (object) 2);
	      ap = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k2_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-89>"),
				      (object) value1_reg,
				      (object) value2_reg, (object) ap,
				      (object) k2);
	      ap_reg = PJScheme._hatcdr_hat ((object) ap);
	      s_reg = s;
	      pattern_reg = PJScheme.cdr ((object) pattern);
	      pc = (Function) instantiate_hat;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont2-91>"))))
	   {
	      object s2 = null;
	      object k2 = null;
	      k2 = PJScheme.list_ref ((object) temp_1, (object) 2);
	      s2 = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k2_reg = k2;
	      ap_reg = value2_reg;
	      s_reg = s2;
	      pattern_reg = value1_reg;
	      pc = (Function) instantiate_hat;
	   }
	 else
	    throw new
	       Exception (format
			  (symbol ("apply-cont2") + ": " +
			   "bad continuation2: ~a", k_reg));
      }

   }

   new public static object make_cont3 (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("continuation3"), (object) args));
   }

   new public static void apply_cont3 ()
   {
      {
	 object temp_1 = null;
	 temp_1 = PJScheme.cdr ((object) k_reg);
	 if (true_q
	     (PJScheme.
	      Eq ((object) PJScheme.car ((object) temp_1),
		  (object) symbol ("<cont3-1>"))))
	   {
	      object src = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 2);
	      src = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q
		  (PJScheme.
		   token_type_q ((object) value1_reg,
				 (object) symbol ("end-marker"))))
		{
		   value2_reg = value3_reg;
		   value1_reg = PJScheme.list ((object) value1_reg);
		   k_reg = k;
		   pc = (Function) apply_cont2;

		}
	      else
		{
		   k_reg =
		      PJScheme.make_cont2 ((object) symbol ("<cont2-1>"),
					   (object) value1_reg, (object) k);
		   fail_reg = value3_reg;
		   handler_reg = handler;
		   src_reg = src;
		   chars_reg = value2_reg;
		   pc = (Function) scan_input_loop;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont3-2>"))))
	   {
	      final_reg = value1_reg;
	      pc = null;

	   }
	 else
	    throw new
	       Exception (format
			  (symbol ("apply-cont3") + ": " +
			   "bad continuation3: ~a", k_reg));
      }

   }

   new public static object make_cont4 (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("continuation4"), (object) args));
   }

   new public static void apply_cont4 ()
   {
      {
	 object temp_1 = null;
	 temp_1 = PJScheme.cdr ((object) k_reg);
	 if (true_q
	     (PJScheme.
	      Eq ((object) PJScheme.car ((object) temp_1),
		  (object) symbol ("<cont4-1>"))))
	   {
	      object src = null;
	      object start = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      start = PJScheme.list_ref ((object) temp_1, (object) 2);
	      src = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg =
		 PJScheme.make_asexp ((object) src, (object) start,
				      (object) value2_reg,
				      (object) PJScheme.
				      list_to_vector ((object) value1_reg));
	      k_reg = k;
	      pc = (Function) apply_cont4;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont4-2>"))))
	   {
	      object src = null;
	      object start = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      start = PJScheme.list_ref ((object) temp_1, (object) 2);
	      src = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg =
		 PJScheme.make_asexp ((object) src, (object) start,
				      (object) value2_reg,
				      (object) value1_reg);
	      k_reg = k;
	      pc = (Function) apply_cont4;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont4-3>"))))
	   {
	      object keyword = null;
	      object keyword_end = null;
	      object src = null;
	      object start = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 5);
	      start = PJScheme.list_ref ((object) temp_1, (object) 4);
	      src = PJScheme.list_ref ((object) temp_1, (object) 3);
	      keyword_end = PJScheme.list_ref ((object) temp_1, (object) 2);
	      keyword = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg =
		 PJScheme.make_asexp ((object) src, (object) start,
				      (object) value2_reg,
				      (object) PJScheme.
				      list ((object) PJScheme.
					    make_asexp ((object) src,
							(object) start,
							(object) keyword_end,
							(object) keyword),
					    (object) value1_reg));
	      k_reg = k;
	      pc = (Function) apply_cont4;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont4-4>"))))
	   {
	      object asexp1 = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 2);
	      asexp1 = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value1_reg =
		 PJScheme.cons ((object) asexp1, (object) value1_reg);
	      k_reg = k;
	      pc = (Function) apply_cont4;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont4-5>"))))
	   {
	      object src = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 2);
	      src = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont4 ((object) symbol ("<cont4-4>"),
				      (object) value1_reg, (object) k);
	      fail_reg = value4_reg;
	      handler_reg = handler;
	      src_reg = src;
	      tokens_reg = value3_reg;
	      pc = (Function) read_avector_sequence;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont4-6>"))))
	   {
	      object asexp1 = null;
	      object expected_terminator = null;
	      object src = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 5);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 4);
	      src = PJScheme.list_ref ((object) temp_1, (object) 3);
	      expected_terminator =
		 PJScheme.list_ref ((object) temp_1, (object) 2);
	      asexp1 = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q
		  ((((bool) PJScheme.null_q_hat ((object) value1_reg))
		    || ((bool) PJScheme.pair_q_hat ((object) value1_reg)))))
		{
		   k_reg = k;
		   fail_reg = value4_reg;
		   handler_reg = handler;
		   src_reg = src;
		   expected_terminator_reg = expected_terminator;
		   tokens_reg = value3_reg;
		   asexps_reg =
		      PJScheme.cons ((object) asexp1,
				     (object) PJScheme.
				     get_sexp ((object) value1_reg));
		   pc = (Function) close_asexp_sequence;

		}
	      else
		{
		   k_reg = k;
		   fail_reg = value4_reg;
		   handler_reg = handler;
		   src_reg = src;
		   expected_terminator_reg = expected_terminator;
		   tokens_reg = value3_reg;
		   asexps_reg =
		      PJScheme.cons ((object) asexp1, (object) value1_reg);
		   pc = (Function) close_asexp_sequence;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont4-7>"))))
	   {
	      object expected_terminator = null;
	      object src = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 3);
	      src = PJScheme.list_ref ((object) temp_1, (object) 2);
	      expected_terminator =
		 PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q
		  (PJScheme.
		   token_type_q ((object) PJScheme.
				 first ((object) value3_reg),
				 (object) symbol ("dot"))))
		{
		   k_reg =
		      PJScheme.make_cont4 ((object) symbol ("<cont4-6>"),
					   (object) value1_reg,
					   (object) expected_terminator,
					   (object) src, (object) handler,
					   (object) k);
		   fail_reg = value4_reg;
		   handler_reg = handler;
		   src_reg = src;
		   tokens_reg = PJScheme.rest_of ((object) value3_reg);
		   pc = (Function) read_asexp;

		}
	      else
		{
		   k_reg =
		      PJScheme.make_cont4 ((object) symbol ("<cont4-4>"),
					   (object) value1_reg, (object) k);
		   fail_reg = value4_reg;
		   handler_reg = handler;
		   src_reg = src;
		   expected_terminator_reg = expected_terminator;
		   tokens_reg = value3_reg;
		   pc = (Function) read_asexp_sequence;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont4-8>"))))
	   {
	      object src = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 3);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 2);
	      src = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-44>"),
				      (object) src, (object) value3_reg,
				      (object) handler, (object) k);
	      fail_reg = value4_reg;
	      handler_reg = handler;
	      adatum_reg = value1_reg;
	      pc = (Function) aparse;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont4-9>"))))
	   {
	      _startokens_left_star = value3_reg;
	      k_reg = PJScheme.make_cont2 ((object) symbol ("<cont2-46>"));
	      fail_reg = value4_reg;
	      handler_reg = REP_handler;
	      adatum_reg = value1_reg;
	      pc = (Function) aparse;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont4-10>"))))
	   {
	      object src = null;
	      object env = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 4);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 3);
	      env = PJScheme.list_ref ((object) temp_1, (object) 2);
	      src = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-50>"),
				      (object) src, (object) value3_reg,
				      (object) env, (object) handler,
				      (object) k);
	      fail_reg = value4_reg;
	      handler_reg = handler;
	      adatum_reg = value1_reg;
	      pc = (Function) aparse;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont4-11>"))))
	   {
	      object handler = null;
	      object k2 = null;
	      k2 = PJScheme.list_ref ((object) temp_1, (object) 2);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q
		  (PJScheme.
		   token_type_q ((object) PJScheme.
				 first ((object) value3_reg),
				 (object) symbol ("end-marker"))))
		{
		   k_reg = k2;
		   fail_reg = value4_reg;
		   handler_reg = handler;
		   adatum_reg = value1_reg;
		   pc = (Function) aparse;

		}
	      else
		{
		   fail_reg = value4_reg;
		   handler_reg = handler;
		   src_reg = symbol ("stdin");
		   tokens_reg = value3_reg;
		   msg_reg = "tokens left over";
		   pc = (Function) read_error;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<cont4-12>"))))
	   {
	      object handler = null;
	      object k2 = null;
	      k2 = PJScheme.list_ref ((object) temp_1, (object) 2);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q
		  (PJScheme.
		   token_type_q ((object) PJScheme.
				 first ((object) value3_reg),
				 (object) symbol ("end-marker"))))
		{
		   value2_reg = value4_reg;
		   k_reg = k2;
		   pc = (Function) apply_cont2;

		}
	      else
		{
		   fail_reg = value4_reg;
		   handler_reg = handler;
		   src_reg = symbol ("stdin");
		   tokens_reg = value3_reg;
		   msg_reg = "tokens left over";
		   pc = (Function) read_error;

		}
	   }
	 else
	    throw new
	       Exception (format
			  (symbol ("apply-cont4") + ": " +
			   "bad continuation4: ~a", k_reg));
      }

   }

   new public static object make_fail (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("fail-continuation"), (object) args));
   }

   new public static void apply_fail ()
   {
      {
	 object temp_1 = null;
	 temp_1 = PJScheme.cdr ((object) fail_reg);
	 if (true_q
	     (PJScheme.
	      Eq ((object) PJScheme.car ((object) temp_1),
		  (object) symbol ("<fail-1>"))))
	   {
	      final_reg = "no more choices";
	      pc = null;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<fail-2>"))))
	   {
	      object binding = null;
	      object old_value = null;
	      object fail = null;
	      fail = PJScheme.list_ref ((object) temp_1, (object) 3);
	      old_value = PJScheme.list_ref ((object) temp_1, (object) 2);
	      binding = PJScheme.list_ref ((object) temp_1, (object) 1);
	      PJScheme.set_binding_value_b ((object) binding,
					    (object) old_value);
	      fail_reg = fail;
	      pc = (Function) apply_fail;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<fail-3>"))))
	   {
	      object exps = null;
	      object env = null;
	      object handler = null;
	      object fail = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 5);
	      fail = PJScheme.list_ref ((object) temp_1, (object) 4);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 3);
	      env = PJScheme.list_ref ((object) temp_1, (object) 2);
	      exps = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg = k;
	      fail_reg = fail;
	      handler_reg = handler;
	      env_reg = env;
	      exps_reg = PJScheme.cdr ((object) exps);
	      pc = (Function) eval_choices;
	   }
	 else
	    throw new
	       Exception (format
			  (symbol ("apply-fail") + ": " +
			   "bad fail-continuation: ~a", fail_reg));
      }

   }

   new public static object make_handler (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("handler"), (object) args));
   }

   new public static void apply_handler ()
   {
      {
	 object temp_1 = null;
	 temp_1 = PJScheme.cdr ((object) handler_reg);
	 if (true_q
	     (PJScheme.
	      Eq ((object) PJScheme.car ((object) temp_1),
		  (object) symbol ("<handler-1>"))))
	   {
	      final_reg =
		 PJScheme.list ((object) symbol ("exception"),
				(object) exception_reg);
	      pc = null;

	   }
	 else
	    throw new
	       Exception (format
			  (symbol ("apply-handler") + ": " +
			   "bad handler: ~a", handler_reg));
      }

   }

   new public static object make_handler2 (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("handler2"), (object) args));
   }

   new public static void apply_handler2 ()
   {
      {
	 object temp_1 = null;
	 temp_1 = PJScheme.cdr ((object) handler_reg);
	 if (true_q
	     (PJScheme.
	      Eq ((object) PJScheme.car ((object) temp_1),
		  (object) symbol ("<handler2-1>"))))
	   {
	      final_reg =
		 PJScheme.list ((object) symbol ("exception"),
				(object) exception_reg);
	      pc = null;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<handler2-2>"))))
	   {
	      _starlast_fail_star = fail_reg;
	      final_reg =
		 PJScheme.list ((object) symbol ("exception"),
				(object) exception_reg);
	      pc = null;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<handler2-3>"))))
	   {
	      final_reg = false;
	      pc = null;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<handler2-4>"))))
	   {
	      object cexps = null;
	      object cvar = null;
	      object env = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 5);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 4);
	      env = PJScheme.list_ref ((object) temp_1, (object) 3);
	      cvar = PJScheme.list_ref ((object) temp_1, (object) 2);
	      cexps = PJScheme.list_ref ((object) temp_1, (object) 1);
	      {
		 object new_env = null;
		 new_env =
		    PJScheme.extend ((object) env,
				     (object) PJScheme.list ((object) cvar),
				     (object) PJScheme.
				     list ((object) exception_reg));
		 k_reg = k;
		 handler_reg = handler;
		 env_reg = new_env;
		 exps_reg = cexps;
		 pc = (Function) eval_sequence;
	      }
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<handler2-5>"))))
	   {
	      object fexps = null;
	      object env = null;
	      object handler = null;
	      handler = PJScheme.list_ref ((object) temp_1, (object) 3);
	      env = PJScheme.list_ref ((object) temp_1, (object) 2);
	      fexps = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-66>"),
				      (object) exception_reg,
				      (object) handler);
	      handler_reg = handler;
	      env_reg = env;
	      exps_reg = fexps;
	      pc = (Function) eval_sequence;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<handler2-6>"))))
	   {
	      object cexps = null;
	      object cvar = null;
	      object fexps = null;
	      object env = null;
	      object handler = null;
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 6);
	      handler = PJScheme.list_ref ((object) temp_1, (object) 5);
	      env = PJScheme.list_ref ((object) temp_1, (object) 4);
	      fexps = PJScheme.list_ref ((object) temp_1, (object) 3);
	      cvar = PJScheme.list_ref ((object) temp_1, (object) 2);
	      cexps = PJScheme.list_ref ((object) temp_1, (object) 1);
	      {
		 object new_env = null;
		 new_env =
		    PJScheme.extend ((object) env,
				     (object) PJScheme.list ((object) cvar),
				     (object) PJScheme.
				     list ((object) exception_reg));
		 {
		    object catch_handler = null;
		    catch_handler =
		       PJScheme.try_finally_handler ((object) fexps,
						     (object) env,
						     (object) handler);
		    k_reg =
		       PJScheme.make_cont2 ((object) symbol ("<cont2-57>"),
					    (object) fexps, (object) env,
					    (object) handler, (object) k);
		    handler_reg = catch_handler;
		    env_reg = new_env;
		    exps_reg = cexps;
		    pc = (Function) eval_sequence;
		 }
	      }
	   }
	 else
	    throw new
	       Exception (format
			  (symbol ("apply-handler2") + ": " +
			   "bad handler2: ~a", handler_reg));
      }

   }

   new public static void apply_proc ()
   {
      {
	 object temp_1 = null;
	 temp_1 = PJScheme.cdr ((object) proc_reg);
	 if (true_q
	     (PJScheme.
	      Eq ((object) PJScheme.car ((object) temp_1),
		  (object) symbol ("<proc-1>"))))
	   {
	      object bodies = null;
	      object formals = null;
	      object env = null;
	      env = PJScheme.list_ref ((object) temp_1, (object) 3);
	      formals = PJScheme.list_ref ((object) temp_1, (object) 2);
	      bodies = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q
		  (PJScheme.
		   EqualSign ((object) PJScheme.length ((object) args_reg),
			      (object) PJScheme.length ((object) formals))))
		{
		   k_reg = k2_reg;
		   env_reg =
		      PJScheme.extend ((object) env, (object) formals,
				       (object) args_reg);
		   exps_reg = bodies;
		   pc = (Function) eval_sequence;

		}
	      else
		{
		   msg_reg = "incorrect number of arguments in application";
		   pc = (Function) runtime_error;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-2>"))))
	   {
	      object bodies = null;
	      object formals = null;
	      object runt = null;
	      object env = null;
	      env = PJScheme.list_ref ((object) temp_1, (object) 4);
	      runt = PJScheme.list_ref ((object) temp_1, (object) 3);
	      formals = PJScheme.list_ref ((object) temp_1, (object) 2);
	      bodies = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q
		  (PJScheme.
		   GreaterOrEqual ((object) PJScheme.
				   length ((object) args_reg),
				   (object) PJScheme.
				   length ((object) formals))))
		{
		   object new_env = null;
		   new_env =
		      PJScheme.extend ((object) env,
				       (object) PJScheme.cons ((object) runt,
							       (object)
							       formals),
				       (object) PJScheme.
				       cons ((object) PJScheme.
					     list_tail ((object) args_reg,
							(object) PJScheme.
							length ((object)
								formals)),
					     (object) PJScheme.
					     list_head ((object) args_reg,
							(object) PJScheme.
							length ((object)
								formals))));
		   k_reg = k2_reg;
		   env_reg = new_env;
		   exps_reg = bodies;
		   pc = (Function) eval_sequence;
		}
	      else
		{
		   msg_reg = "not enough arguments in application";
		   pc = (Function) runtime_error;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-3>"))))
	   {
	      value2_reg = fail_reg;
	      value1_reg = void_value;
	      k_reg = k2_reg;
	      pc = (Function) apply_cont2;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-4>"))))
	   {
	      final_reg = end_of_session;
	      pc = null;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-5>"))))
	   {
	      k_reg =
		 PJScheme.make_cont ((object) symbol ("<cont-34>"),
				     (object) handler_reg, (object) fail_reg,
				     (object) k2_reg);
	      x_reg = PJScheme.car ((object) args_reg);
	      pc = (Function) reannotate_cps;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-6>"))))
	   {
	      k_reg =
		 PJScheme.make_cont ((object) symbol ("<cont-35>"),
				     (object) handler_reg, (object) fail_reg,
				     (object) k2_reg);
	      x_reg = PJScheme.car ((object) args_reg);
	      pc = (Function) reannotate_cps;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-7>"))))
	   {
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-71>"),
				      (object) handler_reg, (object) k2_reg);
	      src_reg = symbol ("stdin");
	      input_reg = PJScheme.car ((object) args_reg);
	      pc = (Function) scan_input;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-8>"))))
	   {
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-72>"),
				      (object) handler_reg, (object) k2_reg);
	      src_reg = symbol ("stdin");
	      input_reg = PJScheme.car ((object) args_reg);
	      pc = (Function) scan_input;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-9>"))))
	   {
	      object proc = null;
	      object proc_args = null;
	      proc_args = PJScheme.cadr ((object) args_reg);
	      proc = PJScheme.car ((object) args_reg);
	      args_reg = proc_args;
	      proc_reg = proc;
	      pc = (Function) apply_proc;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-10>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_one_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to sqrt";
		 pc = (Function) runtime_error;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    not ((object) PJScheme.
			 all_numeric_q ((object) args_reg))))
	      {
		 msg_reg = "sqrt called on non-numeric argument(s)";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (sqrt_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-11>"))))
	   {
	      for_each (safe_print_proc, (object) args_reg);
	      value2_reg = fail_reg;
	      value1_reg = void_value;
	      k_reg = k2_reg;
	      pc = (Function) apply_cont2;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-12>"))))
	   {
	      object s = null;
	      s = PJScheme.format ((object) "~a",
				   (object) PJScheme.car ((object) args_reg));
	      config.NEED_NEWLINE =
		 PJScheme.true_q ((object) PJScheme.
				  not ((object) PJScheme.
				       ends_with_newline_q ((string) s)));
	      PJScheme.display ((object) s);
	      value2_reg = fail_reg;
	      value1_reg = void_value;
	      k_reg = k2_reg;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-13>"))))
	   {
	      config.NEED_NEWLINE = false;
	      PJScheme.newline ();
	      value2_reg = fail_reg;
	      value1_reg = void_value;
	      k_reg = k2_reg;
	      pc = (Function) apply_cont2;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-14>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_one_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to load";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 k_reg = k2_reg;
		 env_reg = toplevel_env;
		 filename_reg = PJScheme.car ((object) args_reg);
		 pc = (Function) load_file;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-15>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_one_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to length";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 ls_reg = PJScheme.car ((object) args_reg);
		 sum_reg = 0;
		 x_reg = PJScheme.car ((object) args_reg);
		 pc = (Function) length_loop;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-16>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_one_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to symbol?";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (symbol_q_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-17>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_one_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to number?";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (number_q_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-18>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_one_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to boolean?";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (boolean_q_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-19>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_one_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to string?";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (string_q_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-20>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_one_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to null?";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (null_q_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-21>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_one_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to pair?";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (pair_q_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-22>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_two_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to cons";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (cons_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-23>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_one_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to car";
		 pc = (Function) runtime_error;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    not ((object) PJScheme.
			 pair_q ((object) PJScheme.car ((object) args_reg)))))
	      {
		 msg_reg =
		    PJScheme.format ((object) "car called on non-pair ~s",
				     (object) PJScheme.
				     car ((object) args_reg));
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (car_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-24>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_one_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to cdr";
		 pc = (Function) runtime_error;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    not ((object) PJScheme.
			 pair_q ((object) PJScheme.car ((object) args_reg)))))
	      {
		 msg_reg =
		    PJScheme.format ((object) "cdr called on non-pair ~s",
				     (object) PJScheme.
				     car ((object) args_reg));
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (cdr_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-25>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_one_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to cadr";
		 pc = (Function) runtime_error;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    not ((object) PJScheme.
			 length_at_least_q ((object) 2,
					    (object) PJScheme.
					    car ((object) args_reg)))))
	      {
		 msg_reg =
		    PJScheme.
		    format ((object)
			    "cadr called on incorrect list structure ~s",
			    (object) PJScheme.car ((object) args_reg));
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (cadr_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-26>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_one_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to caddr";
		 pc = (Function) runtime_error;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    not ((object) PJScheme.
			 length_at_least_q ((object) 3,
					    (object) PJScheme.
					    car ((object) args_reg)))))
	      {
		 msg_reg =
		    PJScheme.
		    format ((object)
			    "caddr called on incorrect list structure ~s",
			    (object) PJScheme.car ((object) args_reg));
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (caddr_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-27>"))))
	   {
	      value2_reg = fail_reg;
	      value1_reg = args_reg;
	      k_reg = k2_reg;
	      pc = (Function) apply_cont2;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-28>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.all_numeric_q ((object) args_reg))))
	      {
		 msg_reg = "+ called on non-numeric argument(s)";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (Add_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-29>"))))
	    if (true_q (PJScheme.null_q ((object) args_reg)))
	      {
		 msg_reg = "incorrect number of arguments to -";
		 pc = (Function) runtime_error;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    not ((object) PJScheme.
			 all_numeric_q ((object) args_reg))))
	      {
		 msg_reg = "- called on non-numeric argument(s)";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (Subtract_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-30>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.all_numeric_q ((object) args_reg))))
	      {
		 msg_reg = "* called on non-numeric argument(s)";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (Multiply_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-31>"))))
	    if (true_q (PJScheme.null_q ((object) args_reg)))
	      {
		 msg_reg = "incorrect number of arguments to /";
		 pc = (Function) runtime_error;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    not ((object) PJScheme.
			 all_numeric_q ((object) args_reg))))
	      {
		 msg_reg = "/ called on non-numeric argument(s)";
		 pc = (Function) runtime_error;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    member ((object) 0,
			    (object) PJScheme.cdr ((object) args_reg))))
	      {
		 msg_reg = "division by zero";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (Divide_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-32>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.
		      length_at_least_q ((object) 2, (object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to <";
		 pc = (Function) runtime_error;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    not ((object) PJScheme.
			 all_numeric_q ((object) args_reg))))
	      {
		 msg_reg = "< called on non-numeric argument(s)";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (LessThan_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-33>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.
		      length_at_least_q ((object) 2, (object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to >";
		 pc = (Function) runtime_error;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    not ((object) PJScheme.
			 all_numeric_q ((object) args_reg))))
	      {
		 msg_reg = "> called on non-numeric argument(s)";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (GreaterThan_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-34>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.
		      length_at_least_q ((object) 2, (object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to <=";
		 pc = (Function) runtime_error;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    not ((object) PJScheme.
			 all_numeric_q ((object) args_reg))))
	      {
		 msg_reg = "<= called on non-numeric argument(s)";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (LessThan_is__proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-35>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.
		      length_at_least_q ((object) 2, (object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to >=";
		 pc = (Function) runtime_error;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    not ((object) PJScheme.
			 all_numeric_q ((object) args_reg))))
	      {
		 msg_reg = ">= called on non-numeric argument(s)";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (GreaterOrEqual_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-36>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.
		      length_at_least_q ((object) 2, (object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to =";
		 pc = (Function) runtime_error;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    not ((object) PJScheme.
			 all_numeric_q ((object) args_reg))))
	      {
		 msg_reg = "= called on non-numeric argument(s)";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (EqualSign_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-37>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_one_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to abs";
		 pc = (Function) runtime_error;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    not ((object) PJScheme.
			 all_numeric_q ((object) args_reg))))
	      {
		 msg_reg = "abs called on non-numeric argument(s)";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (abs_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-38>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_two_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to equal?";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 k_reg =
		    PJScheme.make_cont ((object) symbol ("<cont-36>"),
					(object) fail_reg, (object) k2_reg);
		 y_reg = PJScheme.cadr ((object) args_reg);
		 x_reg = PJScheme.car ((object) args_reg);
		 pc = (Function) equal_objects_q;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-39>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_two_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to eq?";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (Eq_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-40>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_two_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to memq";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (memq_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-41>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_two_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to member";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 k_reg = k2_reg;
		 ls_reg = PJScheme.cadr ((object) args_reg);
		 y_reg = PJScheme.cadr ((object) args_reg);
		 x_reg = PJScheme.car ((object) args_reg);
		 pc = (Function) member_loop;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-42>"))))
	    if (true_q
		((((bool) PJScheme.null_q ((object) args_reg))
		  || ((bool) PJScheme.
		      length_at_least_q ((object) 4, (object) args_reg)))))
	      {
		 msg_reg = "incorrect number of arguments to range";
		 pc = (Function) runtime_error;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    not ((object) PJScheme.
			 all_numeric_q ((object) args_reg))))
	      {
		 msg_reg = "range called on non-numeric argument(s)";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (range_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-43>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_two_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to set-car!";
		 pc = (Function) runtime_error;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    not ((object) PJScheme.
			 pair_q ((object) PJScheme.car ((object) args_reg)))))
	      {
		 msg_reg =
		    PJScheme.
		    format ((object) "set-car! called on non-pair ~s",
			    (object) PJScheme.car ((object) args_reg));
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (set_car_b_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-44>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_two_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to set-cdr!";
		 pc = (Function) runtime_error;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    not ((object) PJScheme.
			 pair_q ((object) PJScheme.car ((object) args_reg)))))
	      {
		 msg_reg =
		    PJScheme.
		    format ((object) "set-cdr! called on non-pair ~s",
			    (object) PJScheme.car ((object) args_reg));
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (set_cdr_b_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-45>"))))
	   {
	      object filename = null;
	      filename = PJScheme.car ((object) args_reg);
	      if (true_q
		  (PJScheme.
		   null_q ((object) PJScheme.cdr ((object) args_reg))))
		{
		   k_reg = k2_reg;
		   info_reg = symbol ("none");
		   env_reg = env2_reg;
		   filename_reg = filename;
		   pc = (Function) load_file;

		}
	      else
		{
		   object module_name = null;
		   module_name = PJScheme.cadr ((object) args_reg);
		   k_reg =
		      PJScheme.make_cont2 ((object) symbol ("<cont2-76>"),
					   (object) filename,
					   (object) env2_reg,
					   (object) handler_reg,
					   (object) k2_reg);
		   env_reg = env2_reg;
		   var_reg = module_name;
		   pc = (Function) lookup_binding_in_first_frame;
		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-46>"))))
	   {
	      k_reg = k2_reg;
	      env_reg = env2_reg;
	      pc = (Function) get_primitive;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-47>"))))
	   {
	      object k = null;
	      k = PJScheme.list_ref ((object) temp_1, (object) 1);
	      value2_reg = fail_reg;
	      value1_reg = PJScheme.car ((object) args_reg);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-48>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_one_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to call/cc";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 object proc = null;
		 proc = PJScheme.car ((object) args_reg);
		 if (true_q
		     (PJScheme.
		      not ((object) PJScheme.
			   procedure_object_q ((object) proc))))
		   {
		      msg_reg = "call/cc called with non-procedure";
		      pc = (Function) runtime_error;

		   }
		 else
		   {
		      object fake_k = null;
		      fake_k =
			 PJScheme.make_proc ((object) symbol ("<proc-47>"),
					     (object) k2_reg);
		      if (true_q (PJScheme.dlr_exp_q ((object) proc)))
			{
			   value2_reg = fail_reg;
			   value1_reg =
			      PJScheme.dlr_apply ((object) proc,
						  (object) PJScheme.
						  list ((object) fake_k));
			   k_reg = k2_reg;
			   pc = (Function) apply_cont2;

			}
		      else
			{
			   args_reg = PJScheme.list ((object) fake_k);
			   proc_reg = proc;
			   pc = (Function) apply_proc;

			}
		   }
	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-49>"))))
	    if (true_q (PJScheme.null_q ((object) args_reg)))
	      {
		 value2_reg = fail_reg;
		 value1_reg = void_value;
		 k_reg = REP_k;
		 pc = (Function) apply_cont2;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = PJScheme.car ((object) args_reg);
		 k_reg = REP_k;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-50>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_one_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to require";
		 pc = (Function) runtime_error;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    true_q ((object) PJScheme.car ((object) args_reg))))
	      {
		 value2_reg = fail_reg;
		 value1_reg = symbol ("ok");
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	    else
	       pc = (Function) apply_fail;
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-51>"))))
	    if (true_q
		(PJScheme.not ((object) PJScheme.null_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to cut";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = REP_fail;
		 value1_reg = symbol ("ok");
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-52>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_one_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to reverse";
		 pc = (Function) runtime_error;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    not ((object) PJScheme.list_q ((object) args_reg))))
	      {
		 msg_reg =
		    PJScheme.
		    format ((object)
			    "reverse called on incorrect list structure ~s",
			    (object) PJScheme.car ((object) args_reg));
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (reverse_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-53>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_two_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to append";
		 pc = (Function) runtime_error;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    not ((object) PJScheme.
			 list_q ((object) PJScheme.car ((object) args_reg)))))
	      {
		 msg_reg =
		    PJScheme.
		    format ((object)
			    "append called on incorrect list structure ~s",
			    (object) PJScheme.car ((object) args_reg));
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 k_reg =
		    PJScheme.make_cont ((object) symbol ("<cont-36>"),
					(object) fail_reg, (object) k2_reg);
		 lists_reg = args_reg;
		 pc = (Function) append_all;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-54>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_one_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to list->vector";
		 pc = (Function) runtime_error;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    not ((object) PJScheme.
			 list_q ((object) PJScheme.car ((object) args_reg)))))
	      {
		 msg_reg =
		    PJScheme.
		    format ((object)
			    "list->vector called on incorrect list structure ~s",
			    (object) PJScheme.car ((object) args_reg));
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (list_to_vector_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-55>"))))
	   {
	      value2_reg = fail_reg;
	      value1_reg =
		 PJScheme.dir ((object) args_reg, (object) env2_reg);
	      k_reg = k2_reg;
	      pc = (Function) apply_cont2;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-56>"))))
	   {
	      value2_reg = fail_reg;
	      value1_reg = PJScheme.get_current_time ();
	      k_reg = k2_reg;
	      pc = (Function) apply_cont2;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-57>"))))
	   {
	      k_reg = k2_reg;
	      env_reg = env2_reg;
	      proc_reg = PJScheme.car ((object) args_reg);
	      args_reg = PJScheme.cdr ((object) args_reg);
	      pc = (Function) map_primitive;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-58>"))))
	   {
	      k_reg = k2_reg;
	      env_reg = env2_reg;
	      lists_reg = PJScheme.cdr ((object) args_reg);
	      proc_reg = PJScheme.car ((object) args_reg);
	      pc = (Function) for_each_primitive;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-59>"))))
	   {
	      value2_reg = fail_reg;
	      value1_reg = env2_reg;
	      k_reg = k2_reg;
	      pc = (Function) apply_cont2;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-60>"))))
	   {
	      value2_reg = fail_reg;
	      value1_reg =
		 PJScheme.using_prim ((object) args_reg, (object) env2_reg);
	      k_reg = k2_reg;
	      pc = (Function) apply_cont2;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-61>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_one_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to not";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg =
		    PJScheme.not ((object) PJScheme.car ((object) args_reg));
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-62>"))))
	   {
	      apply (printf_prim_proc, (object) args_reg);
	      value2_reg = fail_reg;
	      value1_reg = void_value;
	      k_reg = k2_reg;
	      pc = (Function) apply_cont2;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-63>"))))
	   {
	      value2_reg = fail_reg;
	      value1_reg = PJScheme.list_to_vector ((object) args_reg);
	      k_reg = k2_reg;
	      pc = (Function) apply_cont2;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-64>"))))
	   {
	      value2_reg = fail_reg;
	      value1_reg =
		 PJScheme.vector_set_b ((object) PJScheme.
					car ((object) args_reg),
					(object) PJScheme.
					cadr ((object) args_reg),
					(object) PJScheme.
					caddr ((object) args_reg));
	      k_reg = k2_reg;
	      pc = (Function) apply_cont2;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-65>"))))
	   {
	      value2_reg = fail_reg;
	      value1_reg = apply (vector_ref_proc, (object) args_reg);
	      k_reg = k2_reg;
	      pc = (Function) apply_cont2;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-66>"))))
	   {
	      value2_reg = fail_reg;
	      value1_reg = apply (make_vector_proc, (object) args_reg);
	      k_reg = k2_reg;
	      pc = (Function) apply_cont2;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-67>"))))
	   {
	      object location = null;
	      object message = null;
	      location =
		 PJScheme.format ((object) "Error in ~a: ",
				  (object) PJScheme.car ((object) args_reg));
	      message =
		 PJScheme.string_append ((object) location,
					 (object) apply (format_proc,
							 (object) PJScheme.
							 cdr ((object)
							      args_reg)));
	      msg_reg = message;
	      pc = (Function) runtime_error;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-68>"))))
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.length_two_q ((object) args_reg))))
	      {
		 msg_reg = "incorrect number of arguments to list-ref";
		 pc = (Function) runtime_error;

	      }
	    else
	      {
		 value2_reg = fail_reg;
		 value1_reg = apply (list_ref_proc, (object) args_reg);
		 k_reg = k2_reg;
		 pc = (Function) apply_cont2;

	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<proc-69>"))))
	   {
	      object external_function_object = null;
	      external_function_object =
		 PJScheme.list_ref ((object) temp_1, (object) 1);
	      value2_reg = fail_reg;
	      value1_reg =
		 apply (external_function_object, (object) args_reg);
	      k_reg = k2_reg;
	      pc = (Function) apply_cont2;
	   }
	 else
	    throw new
	       Exception (format
			  (symbol ("apply-proc") + ": " + "bad procedure: ~a",
			   proc_reg));
      }

   }

   new public static object make_macro (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("macro-transformer"), (object) args));
   }

   new public static void apply_macro ()
   {
      {
	 object temp_1 = null;
	 temp_1 = PJScheme.cdr ((object) macro_reg);
	 if (true_q
	     (PJScheme.
	      Eq ((object) PJScheme.car ((object) temp_1),
		  (object) symbol ("<macro-1>"))))
	    if (true_q
		(PJScheme.
		 symbol_q_hat ((object) PJScheme.
			       cadr_hat ((object) datum_reg))))
	      {
		 object name = null;
		 object bindings = null;
		 object vars = null;
		 object exps = null;
		 object bodies = null;
		 name = PJScheme.cadr_hat ((object) datum_reg);
		 bindings = PJScheme.caddr_hat ((object) datum_reg);
		 vars = map_hat (car_hat_proc, (object) bindings);
		 exps = map_hat (cadr_hat_proc, (object) bindings);
		 bodies = PJScheme.cdddr_hat ((object) datum_reg);
		 value_reg =
		    PJScheme.append ((object) PJScheme.
				     list ((object) symbol ("letrec")),
				     (object) PJScheme.
				     append ((object) PJScheme.
					     list ((object) PJScheme.
						   list ((object) PJScheme.
							 append ((object)
								 PJScheme.
								 list ((object) name), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("lambda")), (object) PJScheme.append ((object) PJScheme.list ((object) vars), (object) bodies)))))), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) name), (object) exps))));
		 pc = (Function) apply_cont;
	      }
	    else
	      {
		 object bindings = null;
		 object vars = null;
		 object exps = null;
		 object bodies = null;
		 bindings = PJScheme.cadr_hat ((object) datum_reg);
		 vars = map_hat (car_hat_proc, (object) bindings);
		 exps = map_hat (cadr_hat_proc, (object) bindings);
		 bodies = PJScheme.cddr_hat ((object) datum_reg);
		 value_reg =
		    PJScheme.append ((object) PJScheme.
				     list ((object) PJScheme.
					   append ((object) PJScheme.
						   list ((object)
							 symbol ("lambda")),
						   (object) PJScheme.
						   append ((object) PJScheme.
							   list ((object)
								 vars),
							   (object) bodies))),
				     (object) exps);
		 pc = (Function) apply_cont;
	      }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<macro-2>"))))
	   {
	      object decls = null;
	      object vars = null;
	      object procs = null;
	      object bodies = null;
	      decls = PJScheme.cadr_hat ((object) datum_reg);
	      vars = map_hat (car_hat_proc, (object) decls);
	      procs = map_hat (cadr_hat_proc, (object) decls);
	      bodies = PJScheme.cddr_hat ((object) datum_reg);
	      k2_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-6>"),
				      (object) bodies, (object) k_reg);
	      procs_reg = procs;
	      vars_reg = vars;
	      pc = (Function) create_letrec_assignments_hat;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<macro-3>"))))
	   {
	      object name = null;
	      object formals = null;
	      object bodies = null;
	      bodies = PJScheme.cddr_hat ((object) datum_reg);
	      formals =
		 PJScheme.cdr_hat ((object) PJScheme.
				   cadr_hat ((object) datum_reg));
	      name =
		 PJScheme.car_hat ((object) PJScheme.
				   cadr_hat ((object) datum_reg));
	      value_reg =
		 PJScheme.append ((object) PJScheme.
				  list ((object) symbol ("define")),
				  (object) PJScheme.append ((object) PJScheme.
							    list ((object)
								  name),
							    (object) PJScheme.
							    list ((object)
								  PJScheme.
								  append ((object) PJScheme.list ((object) symbol ("lambda")), (object) PJScheme.append ((object) PJScheme.list ((object) formals), (object) bodies)))));
	      pc = (Function) apply_cont;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<macro-4>"))))
	   {
	      object exps = null;
	      exps = PJScheme.cdr_hat ((object) datum_reg);
	      if (true_q (PJScheme.null_q ((object) exps)))
		{
		   value_reg = true;
		   pc = (Function) apply_cont;

		}
	      else
		 if (true_q
		     (PJScheme.
		      null_q ((object) PJScheme.cdr ((object) exps))))
		{
		   value_reg = PJScheme.car ((object) exps);
		   pc = (Function) apply_cont;

		}
	      else
		{
		   value_reg =
		      PJScheme.append ((object) PJScheme.
				       list ((object) symbol ("if")),
				       (object) PJScheme.
				       append ((object) PJScheme.
					       list ((object) PJScheme.
						     car ((object) exps)),
					       (object) PJScheme.
					       append ((object) PJScheme.
						       list ((object)
							     PJScheme.
							     append ((object)
								     PJScheme.
								     list ((object) symbol ("and")), (object) PJScheme.cdr ((object) exps))), (object) PJScheme.list ((object) false))));
		   pc = (Function) apply_cont;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<macro-5>"))))
	   {
	      object exps = null;
	      exps = PJScheme.cdr_hat ((object) datum_reg);
	      if (true_q (PJScheme.null_q ((object) exps)))
		{
		   value_reg = false;
		   pc = (Function) apply_cont;

		}
	      else
		 if (true_q
		     (PJScheme.
		      null_q ((object) PJScheme.cdr ((object) exps))))
		{
		   value_reg = PJScheme.car ((object) exps);
		   pc = (Function) apply_cont;

		}
	      else
		{
		   value_reg =
		      PJScheme.append ((object) PJScheme.
				       list ((object) symbol ("let")),
				       (object) PJScheme.
				       append ((object) PJScheme.
					       list ((object) PJScheme.
						     append ((object)
							     PJScheme.
							     list ((object)
								   PJScheme.
								   append ((object) PJScheme.list ((object) symbol ("bool")), (object) PJScheme.list ((object) PJScheme.car ((object) exps)))), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("else-code")), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("lambda")), (object) PJScheme.append ((object) PJScheme.list ((object) EmptyList), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("or")), (object) PJScheme.cdr ((object) exps)))))))))), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("if")), (object) PJScheme.append ((object) PJScheme.list ((object) symbol ("bool")), (object) PJScheme.append ((object) PJScheme.list ((object) symbol ("bool")), (object) PJScheme.list ((object) PJScheme.list ((object) symbol ("else-code")))))))));
		   pc = (Function) apply_cont;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<macro-6>"))))
	   {
	      object clauses = null;
	      clauses = PJScheme.cdr_hat ((object) datum_reg);
	      if (true_q (PJScheme.null_q ((object) clauses)))
		{
		   adatum_reg = datum_reg;
		   transformer_name_reg = symbol ("cond-transformer^");
		   pc = (Function) amacro_error;

		}
	      else
		{
		   object first_clause = null;
		   object other_clauses = null;
		   other_clauses = PJScheme.cdr ((object) clauses);
		   first_clause = PJScheme.car ((object) clauses);
		   if (true_q
		       ((((bool) PJScheme.null_q_hat ((object) first_clause))
			 || ((bool) PJScheme.
			     not ((object) PJScheme.
				  list_q_hat ((object) first_clause))))))
		     {
			adatum_reg = datum_reg;
			transformer_name_reg = symbol ("cond-transformer^");
			pc = (Function) amacro_error;

		     }
		   else
		     {
			object test_exp = null;
			object then_exps = null;
			then_exps = PJScheme.cdr_hat ((object) first_clause);
			test_exp = PJScheme.car_hat ((object) first_clause);
			if (true_q
			    (PJScheme.
			     eq_q_hat ((object) test_exp,
				       (object) symbol ("else"))))
			   if (true_q (PJScheme.null_q ((object) then_exps)))
			     {
				adatum_reg =
				   PJScheme.list ((object) symbol ("else"));
				transformer_name_reg =
				   symbol ("cond-transformer^");
				pc = (Function) amacro_error;

			     }
			   else
			      if (true_q
				  (PJScheme.
				   null_q ((object) PJScheme.
					   cdr ((object) then_exps))))
			     {
				value_reg = PJScheme.car ((object) then_exps);
				pc = (Function) apply_cont;

			     }
			   else
			     {
				value_reg =
				   PJScheme.append ((object) PJScheme.
						    list ((object)
							  symbol ("begin")),
						    (object) then_exps);
				pc = (Function) apply_cont;

			     }
			else
			   if (true_q (PJScheme.null_q ((object) then_exps)))
			   if (true_q
			       (PJScheme.null_q ((object) other_clauses)))
			     {
				value_reg =
				   PJScheme.append ((object) PJScheme.
						    list ((object)
							  symbol ("let")),
						    (object) PJScheme.
						    append ((object) PJScheme.
							    list ((object)
								  PJScheme.
								  list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("bool")), (object) PJScheme.list ((object) test_exp)))), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("if")), (object) PJScheme.append ((object) PJScheme.list ((object) symbol ("bool")), (object) PJScheme.list ((object) symbol ("bool")))))));
				pc = (Function) apply_cont;

			     }
			   else
			     {
				value_reg =
				   PJScheme.append ((object) PJScheme.
						    list ((object)
							  symbol ("let")),
						    (object) PJScheme.
						    append ((object) PJScheme.
							    list ((object)
								  PJScheme.
								  append ((object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("bool")), (object) PJScheme.list ((object) test_exp))), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("else-code")), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("lambda")), (object) PJScheme.append ((object) PJScheme.list ((object) EmptyList), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("cond")), (object) other_clauses))))))))), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("if")), (object) PJScheme.append ((object) PJScheme.list ((object) symbol ("bool")), (object) PJScheme.append ((object) PJScheme.list ((object) symbol ("bool")), (object) PJScheme.list ((object) PJScheme.list ((object) symbol ("else-code")))))))));
				pc = (Function) apply_cont;

			     }
			else
			   if (true_q
			       (PJScheme.null_q ((object) other_clauses)))
			   if (true_q
			       (PJScheme.
				null_q ((object) PJScheme.
					cdr ((object) then_exps))))
			     {
				value_reg =
				   PJScheme.append ((object) PJScheme.
						    list ((object)
							  symbol ("if")),
						    (object) PJScheme.
						    append ((object) PJScheme.
							    list ((object)
								  test_exp),
							    (object) PJScheme.
							    list ((object)
								  PJScheme.
								  car ((object) then_exps))));
				pc = (Function) apply_cont;

			     }
			   else
			     {
				value_reg =
				   PJScheme.append ((object) PJScheme.
						    list ((object)
							  symbol ("if")),
						    (object) PJScheme.
						    append ((object) PJScheme.
							    list ((object)
								  test_exp),
							    (object) PJScheme.
							    list ((object)
								  PJScheme.
								  append ((object) PJScheme.list ((object) symbol ("begin")), (object) then_exps))));
				pc = (Function) apply_cont;

			     }
			else
			   if (true_q
			       (PJScheme.
				null_q ((object) PJScheme.
					cdr ((object) then_exps))))
			  {
			     value_reg =
				PJScheme.append ((object) PJScheme.
						 list ((object)
						       symbol ("if")),
						 (object) PJScheme.
						 append ((object) PJScheme.
							 list ((object)
							       test_exp),
							 (object) PJScheme.
							 append ((object)
								 PJScheme.
								 list ((object) PJScheme.car ((object) then_exps)), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("cond")), (object) other_clauses)))));
			     pc = (Function) apply_cont;

			  }
			else
			  {
			     value_reg =
				PJScheme.append ((object) PJScheme.
						 list ((object)
						       symbol ("if")),
						 (object) PJScheme.
						 append ((object) PJScheme.
							 list ((object)
							       test_exp),
							 (object) PJScheme.
							 append ((object)
								 PJScheme.
								 list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("begin")), (object) then_exps)), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("cond")), (object) other_clauses)))));
			     pc = (Function) apply_cont;

			  }
		     }
		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<macro-7>"))))
	   {
	      object bindings = null;
	      object bodies = null;
	      bodies = PJScheme.cddr_hat ((object) datum_reg);
	      bindings =
		 PJScheme.get_sexp ((object) PJScheme.
				    cadr_hat ((object) datum_reg));
	      bodies_reg = bodies;
	      bindings_reg = bindings;
	      pc = (Function) nest_let_star_bindings_hat;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<macro-8>"))))
	   {
	      object exp = null;
	      object clauses = null;
	      clauses = PJScheme.cddr_hat ((object) datum_reg);
	      exp = PJScheme.cadr_hat ((object) datum_reg);
	      k2_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-8>"),
				      (object) exp, (object) k_reg);
	      clauses_reg = clauses;
	      var_reg = symbol ("r");
	      pc = (Function) case_clauses_to_cond_clauses_hat;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<macro-9>"))))
	   {
	      object exp = null;
	      object clauses = null;
	      clauses = PJScheme.cddr_hat ((object) datum_reg);
	      exp = PJScheme.cadr_hat ((object) datum_reg);
	      k2_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-8>"),
				      (object) exp, (object) k_reg);
	      clauses_reg = clauses;
	      var_reg = symbol ("r");
	      pc = (Function) record_case_clauses_to_cond_clauses_hat;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<macro-10>"))))
	   {
	      object datatype_name = null;
	      object type_tester_name = null;
	      datatype_name =
		 PJScheme.get_sexp ((object) PJScheme.
				    cadr_hat ((object) datum_reg));
	      type_tester_name =
		 PJScheme.string_to_symbol ((object) PJScheme.
					    string_append ((object) PJScheme.
							   symbol_to_string ((object) datatype_name), (object) "?"));
	      if (true_q
		  (PJScheme.
		   not ((object) PJScheme.
			eq_q_hat ((object) PJScheme.
				  cadr ((object) PJScheme.
					cdr_hat ((object) datum_reg)),
				  (object) type_tester_name))))
		{
		   adatum_reg = datum_reg;
		   transformer_name_reg =
		      symbol ("define-datatype-transformer^");
		   pc = (Function) amacro_error;

		}
	      else
		{
		   object variants = null;
		   object variant_names = null;
		   object variant_tests = null;
		   object tester_def = null;
		   variants =
		      PJScheme.cddr ((object) PJScheme.
				     cdr_hat ((object) datum_reg));
		   variant_names =
		      PJScheme.
		      define_datatype_variant_names ((object) variants);
		   variant_tests =
		      PJScheme.
		      define_datatype_variant_tests ((object) variants);
		   tester_def =
		      PJScheme.append ((object) PJScheme.
				       list ((object) symbol ("define")),
				       (object) PJScheme.
				       append ((object) PJScheme.
					       list ((object)
						     type_tester_name),
					       (object) PJScheme.
					       list ((object) PJScheme.
						     append ((object)
							     PJScheme.
							     list ((object)
								   symbol
								   ("lambda")),
							     (object)
							     PJScheme.
							     append ((object)
								     PJScheme.
								     list ((object) PJScheme.list ((object) symbol ("x"))), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("and")), (object) PJScheme.append ((object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("pair?")), (object) PJScheme.list ((object) symbol ("x")))), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("not")), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("not")), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("memq")), (object) PJScheme.append ((object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("car")), (object) PJScheme.list ((object) symbol ("x")))), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("quote")), (object) PJScheme.list ((object) variant_names))))))))))))))))));
		   value_reg =
		      PJScheme.append ((object) PJScheme.
				       list ((object) symbol ("begin")),
				       (object) PJScheme.
				       append ((object) PJScheme.
					       list ((object) tester_def),
					       (object) PJScheme.
					       make_define_datatype_defines ((object) variant_names, (object) variant_tests)));
		   pc = (Function) apply_cont;
		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("<macro-11>"))))
	   {
	      object type_name = null;
	      object type_tester_name = null;
	      object exp = null;
	      object clauses = null;
	      type_name =
		 PJScheme.get_sexp ((object) PJScheme.
				    cadr_hat ((object) datum_reg));
	      type_tester_name =
		 PJScheme.string_to_symbol ((object) PJScheme.
					    string_append ((object) PJScheme.
							   symbol_to_string ((object) type_name), (object) "?"));
	      exp = PJScheme.caddr_hat ((object) datum_reg);
	      clauses = PJScheme.cdddr_hat ((object) datum_reg);
	      k2_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-11>"),
				      (object) exp, (object) type_name,
				      (object) type_tester_name,
				      (object) k_reg);
	      clauses_reg = clauses;
	      var_reg = symbol ("r");
	      pc = (Function) record_case_clauses_to_cond_clauses_hat;
	   }
	 else
	    throw new
	       Exception (format
			  (symbol ("apply-macro") + ": " +
			   "bad macro-transformer: ~a", macro_reg));
      }

   }

   new public static object next_avail (object n)
   {
      return ((object) PJScheme.
	      string_ref ((object) chars_to_scan, (object) n));
   }

   new public static object remaining (object n)
   {
      return ((object) PJScheme.Add ((object) 1, (object) n));
   }

   new public static void initialize_scan_counters ()
   {
      scan_line = 1;
      scan_char = 1;
      scan_position = 1;
      last_scan_line = scan_line;
      last_scan_char = scan_char;
      last_scan_position = scan_position;

   }

   new public static void increment_scan_counters (object chars)
   {
      last_scan_line = scan_line;
      last_scan_char = scan_char;
      last_scan_position = scan_position;
      if (true_q
	  (PJScheme.
	   char_is__q ((object) PJScheme.next_avail ((object) chars),
		       (object) NEWLINE)))
	{
	   scan_line = PJScheme.Add ((object) 1, (object) scan_line);
	   scan_char = 1;

	}
      else
	 scan_char = PJScheme.Add ((object) 1, (object) scan_char);
      scan_position = PJScheme.Add ((object) 1, (object) scan_position);

   }

   new public static void mark_token_start ()
   {
      token_start_line = scan_line;
      token_start_char = scan_char;
      token_start_position = scan_position;

   }

   new public static void scan_input ()
   {
      PJScheme.initialize_scan_counters ();
      chars_to_scan =
	 PJScheme.string_append ((object) input_reg,
				 (object) PJScheme.
				 make_string ((object) NULL));
      chars_reg = 0;
      pc = (Function) scan_input_loop;

   }

   new public static void scan_input_loop ()
   {
      k_reg =
	 PJScheme.make_cont3 ((object) symbol ("<cont3-1>"), (object) src_reg,
			      (object) handler_reg, (object) k_reg);
      buffer_reg = EmptyList;
      action_reg =
	 PJScheme.list ((object) symbol ("goto"),
			(object) symbol ("start-state"));
      pc = (Function) apply_action;

   }

   new public static void apply_action ()
   {
      if (true_q
	  (PJScheme.
	   Eq ((object) PJScheme.car ((object) action_reg),
	       (object) symbol ("shift"))))
	{
	   object next = null;
	   next = PJScheme.list_ref ((object) action_reg, (object) 1);
	   PJScheme.increment_scan_counters ((object) chars_reg);
	   buffer_reg =
	      PJScheme.cons ((object) PJScheme.
			     next_avail ((object) chars_reg),
			     (object) buffer_reg);
	   chars_reg = PJScheme.remaining ((object) chars_reg);
	   action_reg = next;
	   pc = (Function) apply_action;
	}
      else
	 if (true_q
	     (PJScheme.
	      Eq ((object) PJScheme.car ((object) action_reg),
		  (object) symbol ("replace"))))
	{
	   object new_char = null;
	   object next = null;
	   next = PJScheme.list_ref ((object) action_reg, (object) 2);
	   new_char = PJScheme.list_ref ((object) action_reg, (object) 1);
	   PJScheme.increment_scan_counters ((object) chars_reg);
	   chars_reg = PJScheme.remaining ((object) chars_reg);
	   buffer_reg =
	      PJScheme.cons ((object) new_char, (object) buffer_reg);
	   action_reg = next;
	   pc = (Function) apply_action;
	}
      else
	 if (true_q
	     (PJScheme.
	      Eq ((object) PJScheme.car ((object) action_reg),
		  (object) symbol ("drop"))))
	{
	   object next = null;
	   next = PJScheme.list_ref ((object) action_reg, (object) 1);
	   PJScheme.increment_scan_counters ((object) chars_reg);
	   chars_reg = PJScheme.remaining ((object) chars_reg);
	   action_reg = next;
	   pc = (Function) apply_action;
	}
      else
	 if (true_q
	     (PJScheme.
	      Eq ((object) PJScheme.car ((object) action_reg),
		  (object) symbol ("goto"))))
	{
	   object state = null;
	   state = PJScheme.list_ref ((object) action_reg, (object) 1);
	   if (true_q
	       (PJScheme.
		Eq ((object) state, (object) symbol ("token-start-state"))))
	      PJScheme.mark_token_start ();
	   {
	      object action = null;
	      action =
		 PJScheme.apply_state ((object) state,
				       (object) PJScheme.
				       next_avail ((object) chars_reg));
	      if (true_q
		  (PJScheme.Eq ((object) action, (object) symbol ("error"))))
		 pc = (Function) unexpected_char_error;
	      else
		{
		   action_reg = action;
		   pc = (Function) apply_action;

		}
	   }
	}
      else
	 if (true_q
	     (PJScheme.
	      Eq ((object) PJScheme.car ((object) action_reg),
		  (object) symbol ("emit"))))
	{
	   object token_type = null;
	   token_type = PJScheme.list_ref ((object) action_reg, (object) 1);
	   k_reg =
	      PJScheme.make_cont ((object) symbol ("<cont-1>"),
				  (object) chars_reg, (object) fail_reg,
				  (object) k_reg);
	   token_type_reg = token_type;
	   pc = (Function) convert_buffer_to_token;
	}
      else
	 throw new
	    Exception (format
		       (symbol ("apply-action") + ": " + "invalid action: ~a",
			action_reg));
   }

   new public static void scan_error ()
   {
      exception_reg =
	 PJScheme.format ((object) "scan error: ~a ~a", (object) msg_reg,
			  (object) PJScheme.where_at ((object) line_reg,
						      (object) char_reg,
						      (object) src_reg));
      pc = (Function) apply_handler2;

   }

   new public static void unexpected_char_error ()
   {
      {
	 object c = null;
	 c = PJScheme.next_avail ((object) chars_reg);
	 if (true_q (PJScheme.char_is__q ((object) c, (object) NULL)))
	   {
	      char_reg = scan_char;
	      line_reg = scan_line;
	      msg_reg = "unexpected end of input";
	      pc = (Function) scan_error;

	   }
	 else
	   {
	      char_reg = scan_char;
	      line_reg = scan_line;
	      msg_reg =
		 PJScheme.
		 format ((object) "unexpected character ~a encountered",
			 (object) c);
	      pc = (Function) scan_error;

	   }
      }

   }

   new public static void convert_buffer_to_token ()
   {
      {
	 object buffer = null;
	 buffer = PJScheme.reverse ((object) buffer_reg);
	 if (true_q
	     (PJScheme.
	      Eq ((object) token_type_reg, (object) symbol ("end-marker"))))
	   {
	      value_reg =
		 PJScheme.make_token ((object) symbol ("end-marker"));
	      pc = (Function) apply_cont;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) token_type_reg, (object) symbol ("integer"))))
	   {
	      value_reg =
		 PJScheme.make_info_token ((object) symbol ("integer"),
					   (object) PJScheme.
					   list_to_string ((object) buffer));
	      pc = (Function) apply_cont;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) token_type_reg, (object) symbol ("decimal"))))
	   {
	      value_reg =
		 PJScheme.make_info_token ((object) symbol ("decimal"),
					   (object) PJScheme.
					   list_to_string ((object) buffer));
	      pc = (Function) apply_cont;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) token_type_reg, (object) symbol ("rational"))))
	   {
	      value_reg =
		 PJScheme.make_info_token ((object) symbol ("rational"),
					   (object) PJScheme.
					   list_to_string ((object) buffer));
	      pc = (Function) apply_cont;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) token_type_reg,
		     (object) symbol ("identifier"))))
	   {
	      value_reg =
		 PJScheme.make_info_token ((object) symbol ("identifier"),
					   (object) PJScheme.
					   string_to_symbol ((object)
							     PJScheme.
							     list_to_string ((object) buffer)));
	      pc = (Function) apply_cont;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) token_type_reg, (object) symbol ("boolean"))))
	   {
	      value_reg =
		 PJScheme.make_info_token ((object) symbol ("boolean"),
					   (object) (((bool) PJScheme.
						      char_is__q ((object)
								  PJScheme.
								  car ((object) buffer), (object) 't')) || ((bool) PJScheme.char_is__q ((object) PJScheme.car ((object) buffer), (object) 'T'))));
	      pc = (Function) apply_cont;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) token_type_reg, (object) symbol ("character"))))
	   {
	      value_reg =
		 PJScheme.make_info_token ((object) symbol ("character"),
					   (object) PJScheme.
					   car ((object) buffer));
	      pc = (Function) apply_cont;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) token_type_reg,
		     (object) symbol ("named-character"))))
	   {
	      object name = null;
	      name = PJScheme.list_to_string ((object) buffer);
	      if (true_q
		  (PJScheme.string_is__q ((object) name, (object) "nul")))
		{
		   value_reg =
		      PJScheme.make_info_token ((object) symbol ("character"),
						(object) NULL);
		   pc = (Function) apply_cont;

		}
	      else
		 if (true_q
		     (PJScheme.
		      string_is__q ((object) name, (object) "space")))
		{
		   value_reg =
		      PJScheme.make_info_token ((object) symbol ("character"),
						(object) ' ');
		   pc = (Function) apply_cont;

		}
	      else
		 if (true_q
		     (PJScheme.string_is__q ((object) name, (object) "tab")))
		{
		   value_reg =
		      PJScheme.make_info_token ((object) symbol ("character"),
						(object) '\t');
		   pc = (Function) apply_cont;

		}
	      else
		 if (true_q
		     (PJScheme.
		      string_is__q ((object) name, (object) "newline")))
		{
		   value_reg =
		      PJScheme.make_info_token ((object) symbol ("character"),
						(object) NEWLINE);
		   pc = (Function) apply_cont;

		}
	      else
		 if (true_q
		     (PJScheme.
		      string_is__q ((object) name, (object) "linefeed")))
		{
		   value_reg =
		      PJScheme.make_info_token ((object) symbol ("character"),
						(object) NEWLINE);
		   pc = (Function) apply_cont;

		}
	      else
		 if (true_q
		     (PJScheme.
		      string_is__q ((object) name, (object) "backspace")))
		{
		   value_reg =
		      PJScheme.make_info_token ((object) symbol ("character"),
						(object) BACKSPACE);
		   pc = (Function) apply_cont;

		}
	      else
		 if (true_q
		     (PJScheme.
		      string_is__q ((object) name, (object) "return")))
		{
		   value_reg =
		      PJScheme.make_info_token ((object) symbol ("character"),
						(object) '\r');
		   pc = (Function) apply_cont;

		}
	      else
		 if (true_q
		     (PJScheme.string_is__q ((object) name, (object) "page")))
		{
		   value_reg =
		      PJScheme.make_info_token ((object) symbol ("character"),
						(object) '\f');
		   pc = (Function) apply_cont;

		}
	      else
		{
		   char_reg = token_start_char;
		   line_reg = token_start_line;
		   msg_reg =
		      PJScheme.
		      format ((object) "invalid character name #\\~a",
			      (object) name);
		   pc = (Function) scan_error;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) token_type_reg, (object) symbol ("string"))))
	   {
	      value_reg =
		 PJScheme.make_info_token ((object) symbol ("string"),
					   (object) PJScheme.
					   list_to_string ((object) buffer));
	      pc = (Function) apply_cont;

	   }
	 else
	   {
	      value_reg = PJScheme.make_token ((object) token_type_reg);
	      pc = (Function) apply_cont;

	   }
      }

   }

   new public static object make_token (object token_type)
   {
      {
	 object start = null;
	 object end = null;
	 end =
	    PJScheme.list ((object) last_scan_line, (object) last_scan_char,
			   (object) last_scan_position);
	 start =
	    PJScheme.list ((object) token_start_line,
			   (object) token_start_char,
			   (object) token_start_position);
	 if (true_q
	     (PJScheme.
	      Eq ((object) token_type, (object) symbol ("end-marker"))))
	    return ((object) PJScheme.
		    list ((object) token_type, (object) end, (object) end));
	 else
	    return ((object) PJScheme.
		    list ((object) token_type, (object) start, (object) end));
      }

   }

   new public static object make_info_token (object token_type,
					     object token_info)
   {
      return ((object) PJScheme.
	      list ((object) token_type, (object) token_info,
		    (object) PJScheme.list ((object) token_start_line,
					    (object) token_start_char,
					    (object) token_start_position),
		    (object) PJScheme.list ((object) last_scan_line,
					    (object) last_scan_char,
					    (object) last_scan_position)));
   }

   new public static bool token_type_q (object token, object class_name)
   {
      return ((bool) PJScheme.
	      Eq ((object) PJScheme.car ((object) token),
		  (object) class_name));
   }

   new public static object get_token_start (object token)
   {
      return ((object) PJScheme.rac ((object) PJScheme.rdc ((object) token)));
   }

   new public static object get_token_end (object token)
   {
      return ((object) PJScheme.rac ((object) token));
   }

   new public static object get_token_start_line (object token)
   {
      return ((object) PJScheme.
	      car ((object) PJScheme.get_token_start ((object) token)));
   }

   new public static object get_token_start_char (object token)
   {
      return ((object) PJScheme.
	      cadr ((object) PJScheme.get_token_start ((object) token)));
   }

   new public static object get_token_start_pos (object token)
   {
      return ((object) PJScheme.
	      caddr ((object) PJScheme.get_token_start ((object) token)));
   }

   new public static object snoc (object x, object lyst)
   {
      if (true_q (PJScheme.null_q ((object) lyst)))
	 return ((object) PJScheme.list ((object) x));
      else
	 return ((object) PJScheme.
		 cons ((object) PJScheme.car ((object) lyst),
		       (object) PJScheme.snoc ((object) x,
					       (object) PJScheme.
					       cdr ((object) lyst))));
   }

   new public static object rac (object lyst)
   {
      if (true_q (PJScheme.null_q ((object) PJScheme.cdr ((object) lyst))))
	 return ((object) PJScheme.car ((object) lyst));
      else
	 return ((object) PJScheme.
		 rac ((object) PJScheme.cdr ((object) lyst)));
   }

   new public static object rdc (object lyst)
   {
      if (true_q (PJScheme.null_q ((object) PJScheme.cdr ((object) lyst))))
	 return ((object) EmptyList);
      else
	 return ((object) PJScheme.
		 cons ((object) PJScheme.car ((object) lyst),
		       (object) PJScheme.rdc ((object) PJScheme.
					      cdr ((object) lyst))));
   }

   new public static bool char_delimiter_q (object c)
   {
      return ((bool)
	      (((bool) PJScheme.char_whitespace_q ((object) c))
	       || ((bool) PJScheme.
		   char_is__q ((object) c, (object) SINGLEQUOTE))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) '('))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) '['))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) ')'))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) ']'))
	       || ((bool) PJScheme.
		   char_is__q ((object) c, (object) DOUBLEQUOTE))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) ';'))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) '#'))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) NULL))));
   }

   new public static bool char_initial_q (object c)
   {
      return ((bool)
	      (((bool) PJScheme.char_alphabetic_q ((object) c))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) '!'))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) '$'))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) '%'))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) '&'))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) '*'))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) '/'))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) ':'))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) '<'))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) '='))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) '>'))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) '?'))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) '^'))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) '_'))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) TILDE))));
   }

   new public static bool char_special_subsequent_q (object c)
   {
      return ((bool)
	      (((bool) PJScheme.char_is__q ((object) c, (object) '+'))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) '-'))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) '@'))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) '.'))));
   }

   new public static bool char_subsequent_q (object c)
   {
      return ((bool)
	      (((bool) PJScheme.char_initial_q ((object) c))
	       || ((bool) PJScheme.char_numeric_q ((object) c))
	       || ((bool) PJScheme.char_special_subsequent_q ((object) c))));
   }

   new public static bool char_sign_q (object c)
   {
      return ((bool)
	      (((bool) PJScheme.char_is__q ((object) c, (object) '+'))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) '-'))));
   }

   new public static bool char_boolean_q (object c)
   {
      return ((bool)
	      (((bool) PJScheme.char_is__q ((object) c, (object) 't'))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) 'T'))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) 'f'))
	       || ((bool) PJScheme.char_is__q ((object) c, (object) 'F'))));
   }

   new public static object apply_state (object state, object c)
   {
      if (true_q
	  (PJScheme.Eq ((object) state, (object) symbol ("start-state"))))
	 if (true_q (PJScheme.char_whitespace_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("drop"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol ("start-state"))));
	 else if (true_q (PJScheme.char_is__q ((object) c, (object) ';')))
	    return ((object) PJScheme.
		    list ((object) symbol ("drop"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol ("comment-state"))));
	 else if (true_q (PJScheme.char_is__q ((object) c, (object) NULL)))
	    return ((object) PJScheme.
		    list ((object) symbol ("drop"),
			  (object) PJScheme.list ((object) symbol ("emit"),
						  (object)
						  symbol ("end-marker"))));
	 else
	    return ((object) PJScheme.
		    list ((object) symbol ("goto"),
			  (object) symbol ("token-start-state")));
      else
	 if (true_q
	     (PJScheme.
	      Eq ((object) state, (object) symbol ("token-start-state"))))
	 if (true_q (PJScheme.char_is__q ((object) c, (object) '(')))
	    return ((object) PJScheme.
		    list ((object) symbol ("drop"),
			  (object) PJScheme.list ((object) symbol ("emit"),
						  (object)
						  symbol ("lparen"))));
	 else if (true_q (PJScheme.char_is__q ((object) c, (object) '[')))
	    return ((object) PJScheme.
		    list ((object) symbol ("drop"),
			  (object) PJScheme.list ((object) symbol ("emit"),
						  (object)
						  symbol ("lbracket"))));
	 else if (true_q (PJScheme.char_is__q ((object) c, (object) ')')))
	    return ((object) PJScheme.
		    list ((object) symbol ("drop"),
			  (object) PJScheme.list ((object) symbol ("emit"),
						  (object)
						  symbol ("rparen"))));
	 else if (true_q (PJScheme.char_is__q ((object) c, (object) ']')))
	    return ((object) PJScheme.
		    list ((object) symbol ("drop"),
			  (object) PJScheme.list ((object) symbol ("emit"),
						  (object)
						  symbol ("rbracket"))));
	 else
	    if (true_q
		(PJScheme.char_is__q ((object) c, (object) SINGLEQUOTE)))
	    return ((object) PJScheme.
		    list ((object) symbol ("drop"),
			  (object) PJScheme.list ((object) symbol ("emit"),
						  (object)
						  symbol ("apostrophe"))));
	 else
	    if (true_q (PJScheme.char_is__q ((object) c, (object) BACKQUOTE)))
	    return ((object) PJScheme.
		    list ((object) symbol ("drop"),
			  (object) PJScheme.list ((object) symbol ("emit"),
						  (object)
						  symbol ("backquote"))));
	 else if (true_q (PJScheme.char_is__q ((object) c, (object) ',')))
	    return ((object) PJScheme.
		    list ((object) symbol ("drop"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol ("comma-state"))));
	 else if (true_q (PJScheme.char_is__q ((object) c, (object) '#')))
	    return ((object) PJScheme.
		    list ((object) symbol ("drop"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("hash-prefix-state"))));
	 else
	    if (true_q
		(PJScheme.char_is__q ((object) c, (object) DOUBLEQUOTE)))
	    return ((object) PJScheme.
		    list ((object) symbol ("drop"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol ("string-state"))));
	 else if (true_q (PJScheme.char_initial_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("identifier-state"))));
	 else if (true_q (PJScheme.char_sign_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol ("signed-state"))));
	 else if (true_q (PJScheme.char_is__q ((object) c, (object) '.')))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("decimal-point-state"))));
	 else if (true_q (PJScheme.char_numeric_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("whole-number-state"))));
	 else
	    return ((object) symbol ("error"));
      else
	 if (true_q
	     (PJScheme.
	      Eq ((object) state, (object) symbol ("comment-state"))))
	 if (true_q (PJScheme.char_is__q ((object) c, (object) NEWLINE)))
	    return ((object) PJScheme.
		    list ((object) symbol ("drop"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol ("start-state"))));
	 else if (true_q (PJScheme.char_is__q ((object) c, (object) NULL)))
	    return ((object) PJScheme.
		    list ((object) symbol ("drop"),
			  (object) PJScheme.list ((object) symbol ("emit"),
						  (object)
						  symbol ("end-marker"))));
	 else
	    return ((object) PJScheme.
		    list ((object) symbol ("drop"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol ("comment-state"))));
      else
	 if (true_q
	     (PJScheme.Eq ((object) state, (object) symbol ("comma-state"))))
	 if (true_q (PJScheme.char_is__q ((object) c, (object) '@')))
	    return ((object) PJScheme.
		    list ((object) symbol ("drop"),
			  (object) PJScheme.list ((object) symbol ("emit"),
						  (object)
						  symbol ("comma-at"))));
	 else
	    return ((object) PJScheme.
		    list ((object) symbol ("emit"),
			  (object) symbol ("comma")));
      else
	 if (true_q
	     (PJScheme.
	      Eq ((object) state, (object) symbol ("hash-prefix-state"))))
	 if (true_q (PJScheme.char_boolean_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("emit"),
						  (object)
						  symbol ("boolean"))));
	 else
	    if (true_q (PJScheme.char_is__q ((object) c, (object) BACKSLASH)))
	    return ((object) PJScheme.
		    list ((object) symbol ("drop"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("character-state"))));
	 else if (true_q (PJScheme.char_is__q ((object) c, (object) '(')))
	    return ((object) PJScheme.
		    list ((object) symbol ("drop"),
			  (object) PJScheme.list ((object) symbol ("emit"),
						  (object)
						  symbol ("lvector"))));
	 else
	    return ((object) symbol ("error"));
      else
	 if (true_q
	     (PJScheme.
	      Eq ((object) state, (object) symbol ("character-state"))))
	 if (true_q (PJScheme.char_alphabetic_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("alphabetic-character-state"))));
	 else
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.
		      char_is__q ((object) c, (object) NULL))))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("emit"),
						  (object)
						  symbol ("character"))));
	 else
	    return ((object) symbol ("error"));
      else
	 if (true_q
	     (PJScheme.
	      Eq ((object) state,
		  (object) symbol ("alphabetic-character-state"))))
	 if (true_q (PJScheme.char_alphabetic_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("named-character-state"))));
	 else
	    return ((object) PJScheme.
		    list ((object) symbol ("emit"),
			  (object) symbol ("character")));
      else
	 if (true_q
	     (PJScheme.
	      Eq ((object) state, (object) symbol ("named-character-state"))))
	 if (true_q (PJScheme.char_delimiter_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("emit"),
			  (object) symbol ("named-character")));
	 else
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("named-character-state"))));
      else
	 if (true_q
	     (PJScheme.Eq ((object) state, (object) symbol ("string-state"))))
	 if (true_q (PJScheme.char_is__q ((object) c, (object) DOUBLEQUOTE)))
	    return ((object) PJScheme.
		    list ((object) symbol ("drop"),
			  (object) PJScheme.list ((object) symbol ("emit"),
						  (object)
						  symbol ("string"))));
	 else
	    if (true_q (PJScheme.char_is__q ((object) c, (object) BACKSLASH)))
	    return ((object) PJScheme.
		    list ((object) symbol ("drop"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("string-escape-state"))));
	 else
	    if (true_q
		(PJScheme.
		 not ((object) PJScheme.
		      char_is__q ((object) c, (object) NULL))))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol ("string-state"))));
	 else
	    return ((object) symbol ("error"));
      else
	 if (true_q
	     (PJScheme.
	      Eq ((object) state, (object) symbol ("string-escape-state"))))
	 if (true_q (PJScheme.char_is__q ((object) c, (object) DOUBLEQUOTE)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol ("string-state"))));
	 else
	    if (true_q (PJScheme.char_is__q ((object) c, (object) BACKSLASH)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol ("string-state"))));
	 else if (true_q (PJScheme.char_is__q ((object) c, (object) 'b')))
	    return ((object) PJScheme.
		    list ((object) symbol ("replace"), (object) BACKSPACE,
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol ("string-state"))));
	 else if (true_q (PJScheme.char_is__q ((object) c, (object) 'f')))
	    return ((object) PJScheme.
		    list ((object) symbol ("replace"), (object) '\f',
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol ("string-state"))));
	 else if (true_q (PJScheme.char_is__q ((object) c, (object) 'n')))
	    return ((object) PJScheme.
		    list ((object) symbol ("replace"), (object) NEWLINE,
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol ("string-state"))));
	 else if (true_q (PJScheme.char_is__q ((object) c, (object) 't')))
	    return ((object) PJScheme.
		    list ((object) symbol ("replace"), (object) '\t',
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol ("string-state"))));
	 else if (true_q (PJScheme.char_is__q ((object) c, (object) 'r')))
	    return ((object) PJScheme.
		    list ((object) symbol ("replace"), (object) '\r',
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol ("string-state"))));
	 else
	    return ((object) symbol ("error"));
      else
	 if (true_q
	     (PJScheme.
	      Eq ((object) state, (object) symbol ("identifier-state"))))
	 if (true_q (PJScheme.char_subsequent_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("identifier-state"))));
	 else if (true_q (PJScheme.char_delimiter_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("emit"),
			  (object) symbol ("identifier")));
	 else
	    return ((object) symbol ("error"));
      else
	 if (true_q
	     (PJScheme.Eq ((object) state, (object) symbol ("signed-state"))))
	 if (true_q (PJScheme.char_numeric_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("whole-number-state"))));
	 else if (true_q (PJScheme.char_is__q ((object) c, (object) '.')))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("signed-decimal-point-state"))));
	 else if (true_q (PJScheme.char_delimiter_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("emit"),
			  (object) symbol ("identifier")));
	 else if (true_q (PJScheme.char_subsequent_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("identifier-state"))));
	 else
	    return ((object) symbol ("error"));
      else
	 if (true_q
	     (PJScheme.
	      Eq ((object) state, (object) symbol ("decimal-point-state"))))
	 if (true_q (PJScheme.char_numeric_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("fractional-number-state"))));
	 else if (true_q (PJScheme.char_delimiter_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("emit"), (object) symbol ("dot")));
	 else if (true_q (PJScheme.char_subsequent_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("identifier-state"))));
	 else
	    return ((object) symbol ("error"));
      else
	 if (true_q
	     (PJScheme.
	      Eq ((object) state,
		  (object) symbol ("signed-decimal-point-state"))))
	 if (true_q (PJScheme.char_numeric_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("fractional-number-state"))));
	 else if (true_q (PJScheme.char_delimiter_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("emit"),
			  (object) symbol ("identifier")));
	 else if (true_q (PJScheme.char_subsequent_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("identifier-state"))));
	 else
	    return ((object) symbol ("error"));
      else
	 if (true_q
	     (PJScheme.
	      Eq ((object) state, (object) symbol ("whole-number-state"))))
	 if (true_q (PJScheme.char_numeric_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("whole-number-state"))));
	 else if (true_q (PJScheme.char_is__q ((object) c, (object) '.')))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("fractional-number-state"))));
	 else if (true_q (PJScheme.char_is__q ((object) c, (object) '/')))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("rational-number-state"))));
	 else
	    if (true_q
		((((bool) PJScheme.char_is__q ((object) c, (object) 'e'))
		  || ((bool) PJScheme.
		      char_is__q ((object) c, (object) 'E')))))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol ("suffix-state"))));
	 else if (true_q (PJScheme.char_delimiter_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("emit"),
			  (object) symbol ("integer")));
	 else if (true_q (PJScheme.char_subsequent_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("identifier-state"))));
	 else
	    return ((object) symbol ("error"));
      else
	 if (true_q
	     (PJScheme.
	      Eq ((object) state,
		  (object) symbol ("fractional-number-state"))))
	 if (true_q (PJScheme.char_numeric_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("fractional-number-state"))));
	 else
	    if (true_q
		((((bool) PJScheme.char_is__q ((object) c, (object) 'e'))
		  || ((bool) PJScheme.
		      char_is__q ((object) c, (object) 'E')))))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol ("suffix-state"))));
	 else if (true_q (PJScheme.char_delimiter_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("emit"),
			  (object) symbol ("decimal")));
	 else if (true_q (PJScheme.char_subsequent_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("identifier-state"))));
	 else
	    return ((object) symbol ("error"));
      else
	 if (true_q
	     (PJScheme.
	      Eq ((object) state, (object) symbol ("rational-number-state"))))
	 if (true_q (PJScheme.char_numeric_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("rational-number-state*"))));
	 else if (true_q (PJScheme.char_delimiter_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("emit"),
			  (object) symbol ("identifier")));
	 else if (true_q (PJScheme.char_subsequent_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("identifier-state"))));
	 else
	    return ((object) symbol ("error"));
      else
	 if (true_q
	     (PJScheme.
	      Eq ((object) state,
		  (object) symbol ("rational-number-state*"))))
	 if (true_q (PJScheme.char_numeric_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("rational-number-state*"))));
	 else if (true_q (PJScheme.char_delimiter_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("emit"),
			  (object) symbol ("rational")));
	 else if (true_q (PJScheme.char_subsequent_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("identifier-state"))));
	 else
	    return ((object) symbol ("error"));
      else
	 if (true_q
	     (PJScheme.Eq ((object) state, (object) symbol ("suffix-state"))))
	 if (true_q (PJScheme.char_sign_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("signed-exponent-state"))));
	 else if (true_q (PJScheme.char_numeric_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("exponent-state"))));
	 else if (true_q (PJScheme.char_delimiter_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("emit"),
			  (object) symbol ("identifier")));
	 else if (true_q (PJScheme.char_subsequent_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("identifier-state"))));
	 else
	    return ((object) symbol ("error"));
      else
	 if (true_q
	     (PJScheme.
	      Eq ((object) state, (object) symbol ("signed-exponent-state"))))
	 if (true_q (PJScheme.char_numeric_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("exponent-state"))));
	 else if (true_q (PJScheme.char_delimiter_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("emit"),
			  (object) symbol ("identifier")));
	 else if (true_q (PJScheme.char_subsequent_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("identifier-state"))));
	 else
	    return ((object) symbol ("error"));
      else
	 if (true_q
	     (PJScheme.
	      Eq ((object) state, (object) symbol ("exponent-state"))))
	 if (true_q (PJScheme.char_numeric_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("exponent-state"))));
	 else if (true_q (PJScheme.char_delimiter_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("emit"),
			  (object) symbol ("decimal")));
	 else if (true_q (PJScheme.char_subsequent_q ((object) c)))
	    return ((object) PJScheme.
		    list ((object) symbol ("shift"),
			  (object) PJScheme.list ((object) symbol ("goto"),
						  (object)
						  symbol
						  ("identifier-state"))));
	 else
	    return ((object) symbol ("error"));
      else
	 throw new
	    Exception (format
		       (symbol ("apply-state") + ": " + "invalid state: ~a",
			state));
   }

   new public static object first (object x)
   {
      return ((object) PJScheme.car ((object) x));
   }

   new public static object rest_of (object x)
   {
      return ((object) PJScheme.cdr ((object) x));
   }

   new public static void unexpected_token_error ()
   {
      {
	 object token = null;
	 token = PJScheme.first ((object) tokens_reg);
	 if (true_q
	     (PJScheme.
	      token_type_q ((object) token, (object) symbol ("end-marker"))))
	   {
	      msg_reg = "unexpected end of input";
	      pc = (Function) read_error;

	   }
	 else
	   {
	      msg_reg =
		 PJScheme.format ((object) "unexpected ~a encountered",
				  (object) PJScheme.car ((object) token));
	      pc = (Function) read_error;

	   }
      }

   }

   new public static void read_error ()
   {
      {
	 object token = null;
	 token = PJScheme.first ((object) tokens_reg);
	 exception_reg =
	    PJScheme.format ((object) "read error: ~a ~a", (object) msg_reg,
			     (object) PJScheme.where_at ((object) PJScheme.
							 get_token_start_line
							 ((object) token),
							 (object) PJScheme.
							 get_token_start_char
							 ((object) token),
							 (object) src_reg));
	 pc = (Function) apply_handler2;
      }

   }

   new public static object where_at (object line, object chr, object src)
   {
      if (true_q (PJScheme.Eq ((object) src, (object) symbol ("stdin"))))
	 return ((object) PJScheme.
		 format ((object) "at line ~a, char ~a", (object) line,
			 (object) chr));
      else
	 return ((object) PJScheme.
		 format ((object) "at line ~a, char ~a of ~a", (object) line,
			 (object) chr, (object) src));
   }

   new public static object make_asexp (object src, object start, object end,
					object sexp)
   {
      return ((object) PJScheme.
	      list ((object) asexp_tag, (object) sexp,
		    (object) PJScheme.cons ((object) src,
					    (object) PJScheme.
					    append ((object) start,
						    (object) end))));
   }

   new public static object retag (object sexp, object info)
   {
      return ((object) PJScheme.
	      list ((object) asexp_tag, (object) sexp, (object) info));
   }

   new public static object get_sexp (object asexp)
   {
      return ((object) PJScheme.cadr ((object) asexp));
   }

   new public static object get_source_info (object asexp)
   {
      return ((object) PJScheme.caddr ((object) asexp));
   }

   new public static object get_srcfile (object info)
   {
      return ((object) PJScheme.car ((object) info));
   }

   new public static object get_start_line (object info)
   {
      return ((object) PJScheme.cadr ((object) info));
   }

   new public static object get_start_char (object info)
   {
      return ((object) PJScheme.caddr ((object) info));
   }

   new public static object get_start_pos (object info)
   {
      return ((object) PJScheme.cadddr ((object) info));
   }

   new public static object get_end_line (object info)
   {
      return ((object) PJScheme.
	      car ((object) PJScheme.cddddr ((object) info)));
   }

   new public static object get_end_char (object info)
   {
      return ((object) PJScheme.
	      cadr ((object) PJScheme.cddddr ((object) info)));
   }

   new public static object get_end_pos (object info)
   {
      return ((object) PJScheme.
	      caddr ((object) PJScheme.cddddr ((object) info)));
   }

   new public static bool has_source_info_q (object asexp)
   {
      return ((bool) PJScheme.
	      not ((object) PJScheme.
		   Eq ((object) PJScheme.get_source_info ((object) asexp),
		       (object) symbol ("none"))));
   }

   new public static bool original_source_info_q (object asexp)
   {
      return ((bool)
	      (((bool) PJScheme.has_source_info_q ((object) asexp))
	       && ((bool) PJScheme.
		   EqualSign ((object) PJScheme.
			      length ((object) PJScheme.
				      get_source_info ((object) asexp)),
			      (object) 7))));
   }

   new public static bool source_info_q (object x)
   {
      return ((bool)
	      (((bool) PJScheme.Eq ((object) x, (object) symbol ("none")))
	       || ((bool) PJScheme.list_q ((object) x))));
   }

   new public static object replace_info (object asexp, object info)
   {
      return ((object) PJScheme.
	      retag ((object) PJScheme.get_sexp ((object) asexp),
		     (object) info));
   }

   new public static object string_q_hat (object asexp)
   {
      return ((object) PJScheme.
	      string_q ((object) PJScheme.get_sexp ((object) asexp)));
   }

   new public static object eq_q_hat (object asexp, object x)
   {
      return ((object) PJScheme.
	      Eq ((object) PJScheme.get_sexp ((object) asexp), (object) x));
   }

   new public static object vector_q_hat (object asexp)
   {
      return ((object) PJScheme.
	      vector_q ((object) PJScheme.get_sexp ((object) asexp)));
   }

   new public static object vector_to_list_hat (object asexp)
   {
      return ((object) PJScheme.
	      vector_to_list ((object) PJScheme.get_sexp ((object) asexp)));
   }

   new public static object cons_hat (object a, object b, object info)
   {
      if (true_q (PJScheme.null_q_hat ((object) b)))
	 return ((object) PJScheme.
		 retag ((object) PJScheme.list ((object) a), (object) info));
      else if (true_q (PJScheme.pair_q_hat ((object) b)))
	 return ((object) PJScheme.
		 retag ((object) PJScheme.
			cons ((object) a,
			      (object) PJScheme.get_sexp ((object) b)),
			(object) info));
      else
	 return ((object) PJScheme.
		 retag ((object) PJScheme.cons ((object) a, (object) b),
			(object) info));
   }

   new public static object _hatcdr_hat (object asexp)
   {
      if (true_q
	  (PJScheme.asexp_q ((object) PJScheme.cdr_hat ((object) asexp))))
	 return ((object) PJScheme.cdr_hat ((object) asexp));
      else
	 return ((object) PJScheme.
		 retag ((object) PJScheme.cdr_hat ((object) asexp),
			(object) symbol ("none")));
   }

   new public static object null_q_hat (object x)
   {
      return ((object)
	      (((bool) PJScheme.asexp_q ((object) x))
	       && ((bool) PJScheme.
		   null_q ((object) PJScheme.get_sexp ((object) x)))));
   }

   new public static object pair_q_hat (object x)
   {
      return ((object)
	      (((bool) PJScheme.asexp_q ((object) x))
	       && ((bool) PJScheme.
		   pair_q ((object) PJScheme.get_sexp ((object) x)))));
   }

   new public static void unannotate_cps ()
   {
      if (true_q (PJScheme.asexp_q ((object) x_reg)))
	{
	   x_reg = PJScheme.get_sexp ((object) x_reg);
	   pc = (Function) unannotate_cps;

	}
      else if (true_q (PJScheme.pair_q ((object) x_reg)))
	{
	   k_reg =
	      PJScheme.make_cont ((object) symbol ("<cont-4>"),
				  (object) x_reg, (object) k_reg);
	   x_reg = PJScheme.car ((object) x_reg);
	   pc = (Function) unannotate_cps;

	}
      else if (true_q (PJScheme.vector_q ((object) x_reg)))
	{
	   k_reg =
	      PJScheme.make_cont ((object) symbol ("<cont-2>"),
				  (object) k_reg);
	   x_reg = PJScheme.vector_to_list ((object) x_reg);
	   pc = (Function) unannotate_cps;

	}
      else
	{
	   value_reg = x_reg;
	   pc = (Function) apply_cont;

	}

   }

   new public static void reannotate_cps ()
   {
      if (true_q (PJScheme.asexp_q ((object) x_reg)))
	{
	   value_reg = x_reg;
	   pc = (Function) apply_cont;

	}
      else if (true_q (PJScheme.pair_q ((object) x_reg)))
	{
	   k_reg =
	      PJScheme.make_cont ((object) symbol ("<cont-6>"),
				  (object) k_reg);
	   pc = (Function) reannotate_seq_cps;

	}
      else if (true_q (PJScheme.vector_q ((object) x_reg)))
	{
	   k_reg =
	      PJScheme.make_cont ((object) symbol ("<cont-5>"),
				  (object) k_reg);
	   x_reg = PJScheme.vector_to_list ((object) x_reg);
	   pc = (Function) reannotate_seq_cps;

	}
      else
	{
	   value_reg =
	      PJScheme.retag ((object) x_reg, (object) symbol ("none"));
	   pc = (Function) apply_cont;

	}

   }

   new public static void reannotate_seq_cps ()
   {
      if (true_q (PJScheme.null_q ((object) x_reg)))
	{
	   value_reg = EmptyList;
	   pc = (Function) apply_cont;

	}
      else if (true_q (PJScheme.asexp_q ((object) x_reg)))
	{
	   value_reg = x_reg;
	   pc = (Function) apply_cont;

	}
      else
	 if (true_q
	     (PJScheme.not ((object) PJScheme.pair_q ((object) x_reg))))
	 pc = (Function) reannotate_cps;
      else
	 if (true_q
	     ((((bool) PJScheme.
		null_q_hat ((object) PJScheme.cdr ((object) x_reg)))
	       || ((bool) PJScheme.
		   pair_q_hat ((object) PJScheme.cdr ((object) x_reg))))))
	{
	   x_reg =
	      PJScheme.cons ((object) PJScheme.car ((object) x_reg),
			     (object) PJScheme.get_sexp ((object) PJScheme.
							 cdr ((object)
							      x_reg)));
	   pc = (Function) reannotate_seq_cps;

	}
      else
	{
	   k_reg =
	      PJScheme.make_cont ((object) symbol ("<cont-7>"),
				  (object) x_reg, (object) k_reg);
	   x_reg = PJScheme.car ((object) x_reg);
	   pc = (Function) reannotate_cps;

	}

   }

   new public static void read_asexp ()
   {
      {
	 object start = null;
	 object end = null;
	 end =
	    PJScheme.get_token_end ((object) PJScheme.
				    first ((object) tokens_reg));
	 start =
	    PJScheme.get_token_start ((object) PJScheme.
				      first ((object) tokens_reg));
	 {
	    object temp_1 = null;
	    temp_1 = PJScheme.first ((object) tokens_reg);
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("integer"))))
	      {
		 object str = null;
		 str = PJScheme.list_ref ((object) temp_1, (object) 1);
		 value4_reg = fail_reg;
		 value3_reg = PJScheme.rest_of ((object) tokens_reg);
		 value2_reg = end;
		 value1_reg =
		    PJScheme.make_asexp ((object) src_reg, (object) start,
					 (object) end,
					 (object) PJScheme.
					 string_to_integer ((object) str));
		 pc = (Function) apply_cont4;
	      }
	    else
	       if (true_q
		   (PJScheme.
		    Eq ((object) PJScheme.car ((object) temp_1),
			(object) symbol ("decimal"))))
	      {
		 object str = null;
		 str = PJScheme.list_ref ((object) temp_1, (object) 1);
		 value4_reg = fail_reg;
		 value3_reg = PJScheme.rest_of ((object) tokens_reg);
		 value2_reg = end;
		 value1_reg =
		    PJScheme.make_asexp ((object) src_reg, (object) start,
					 (object) end,
					 (object) PJScheme.
					 string_to_decimal ((object) str));
		 pc = (Function) apply_cont4;
	      }
	    else
	       if (true_q
		   (PJScheme.
		    Eq ((object) PJScheme.car ((object) temp_1),
			(object) symbol ("rational"))))
	      {
		 object str = null;
		 str = PJScheme.list_ref ((object) temp_1, (object) 1);
		 {
		    object num = null;
		    num = PJScheme.string_to_rational ((object) str);
		    if (true_q (PJScheme.true_q ((object) num)))
		      {
			 value4_reg = fail_reg;
			 value3_reg = PJScheme.rest_of ((object) tokens_reg);
			 value2_reg = end;
			 value1_reg =
			    PJScheme.make_asexp ((object) src_reg,
						 (object) start, (object) end,
						 (object) num);
			 pc = (Function) apply_cont4;

		      }
		    else
		      {
			 msg_reg =
			    PJScheme.format ((object) "cannot represent ~a",
					     (object) str);
			 pc = (Function) read_error;

		      }
		 }
	      }
	    else
	       if (true_q
		   (PJScheme.
		    Eq ((object) PJScheme.car ((object) temp_1),
			(object) symbol ("boolean"))))
	      {
		 object boolean = null;
		 boolean = PJScheme.list_ref ((object) temp_1, (object) 1);
		 value4_reg = fail_reg;
		 value3_reg = PJScheme.rest_of ((object) tokens_reg);
		 value2_reg = end;
		 value1_reg =
		    PJScheme.make_asexp ((object) src_reg, (object) start,
					 (object) end, (object) boolean);
		 pc = (Function) apply_cont4;
	      }
	    else
	       if (true_q
		   (PJScheme.
		    Eq ((object) PJScheme.car ((object) temp_1),
			(object) symbol ("character"))))
	      {
		 object chr = null;
		 chr = PJScheme.list_ref ((object) temp_1, (object) 1);
		 value4_reg = fail_reg;
		 value3_reg = PJScheme.rest_of ((object) tokens_reg);
		 value2_reg = end;
		 value1_reg =
		    PJScheme.make_asexp ((object) src_reg, (object) start,
					 (object) end, (object) chr);
		 pc = (Function) apply_cont4;
	      }
	    else
	       if (true_q
		   (PJScheme.
		    Eq ((object) PJScheme.car ((object) temp_1),
			(object) symbol ("string"))))
	      {
		 object str = null;
		 str = PJScheme.list_ref ((object) temp_1, (object) 1);
		 value4_reg = fail_reg;
		 value3_reg = PJScheme.rest_of ((object) tokens_reg);
		 value2_reg = end;
		 value1_reg =
		    PJScheme.make_asexp ((object) src_reg, (object) start,
					 (object) end, (object) str);
		 pc = (Function) apply_cont4;
	      }
	    else
	       if (true_q
		   (PJScheme.
		    Eq ((object) PJScheme.car ((object) temp_1),
			(object) symbol ("identifier"))))
	      {
		 object id = null;
		 id = PJScheme.list_ref ((object) temp_1, (object) 1);
		 value4_reg = fail_reg;
		 value3_reg = PJScheme.rest_of ((object) tokens_reg);
		 value2_reg = end;
		 value1_reg =
		    PJScheme.make_asexp ((object) src_reg, (object) start,
					 (object) end, (object) id);
		 pc = (Function) apply_cont4;
	      }
	    else
	       if (true_q
		   (PJScheme.
		    Eq ((object) PJScheme.car ((object) temp_1),
			(object) symbol ("apostrophe"))))
	      {
		 keyword_reg = symbol ("quote");
		 pc = (Function) read_annotated_abbreviation;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    Eq ((object) PJScheme.car ((object) temp_1),
			(object) symbol ("backquote"))))
	      {
		 keyword_reg = symbol ("quasiquote");
		 pc = (Function) read_annotated_abbreviation;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    Eq ((object) PJScheme.car ((object) temp_1),
			(object) symbol ("comma"))))
	      {
		 keyword_reg = symbol ("unquote");
		 pc = (Function) read_annotated_abbreviation;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    Eq ((object) PJScheme.car ((object) temp_1),
			(object) symbol ("comma-at"))))
	      {
		 keyword_reg = symbol ("unquote-splicing");
		 pc = (Function) read_annotated_abbreviation;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    Eq ((object) PJScheme.car ((object) temp_1),
			(object) symbol ("lparen"))))
	      {
		 object tokens = null;
		 tokens = PJScheme.rest_of ((object) tokens_reg);
		 k_reg =
		    PJScheme.make_cont4 ((object) symbol ("<cont4-2>"),
					 (object) src_reg, (object) start,
					 (object) k_reg);
		 expected_terminator_reg = symbol ("rparen");
		 tokens_reg = tokens;
		 pc = (Function) read_asexp_sequence;
	      }
	    else
	       if (true_q
		   (PJScheme.
		    Eq ((object) PJScheme.car ((object) temp_1),
			(object) symbol ("lbracket"))))
	      {
		 object tokens = null;
		 tokens = PJScheme.rest_of ((object) tokens_reg);
		 k_reg =
		    PJScheme.make_cont4 ((object) symbol ("<cont4-2>"),
					 (object) src_reg, (object) start,
					 (object) k_reg);
		 expected_terminator_reg = symbol ("rbracket");
		 tokens_reg = tokens;
		 pc = (Function) read_asexp_sequence;
	      }
	    else
	       if (true_q
		   (PJScheme.
		    Eq ((object) PJScheme.car ((object) temp_1),
			(object) symbol ("lvector"))))
	      {
		 k_reg =
		    PJScheme.make_cont4 ((object) symbol ("<cont4-1>"),
					 (object) src_reg, (object) start,
					 (object) k_reg);
		 tokens_reg = PJScheme.rest_of ((object) tokens_reg);
		 pc = (Function) read_avector_sequence;

	      }
	    else
	       pc = (Function) unexpected_token_error;
	 }
      }

   }

   new public static void read_annotated_abbreviation ()
   {
      {
	 object start = null;
	 object keyword_end = null;
	 keyword_end =
	    PJScheme.get_token_end ((object) PJScheme.
				    first ((object) tokens_reg));
	 start =
	    PJScheme.get_token_start ((object) PJScheme.
				      first ((object) tokens_reg));
	 k_reg =
	    PJScheme.make_cont4 ((object) symbol ("<cont4-3>"),
				 (object) keyword_reg, (object) keyword_end,
				 (object) src_reg, (object) start,
				 (object) k_reg);
	 tokens_reg = PJScheme.rest_of ((object) tokens_reg);
	 pc = (Function) read_asexp;
      }

   }

   new public static void read_avector_sequence ()
   {
      {
	 object temp_1 = null;
	 temp_1 = PJScheme.first ((object) tokens_reg);
	 if (true_q
	     (PJScheme.
	      Eq ((object) PJScheme.car ((object) temp_1),
		  (object) symbol ("rparen"))))
	   {
	      expected_terminator_reg = symbol ("rparen");
	      asexps_reg = EmptyList;
	      pc = (Function) close_asexp_sequence;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("dot"))))
	   {
	      msg_reg = "unexpected dot (.)";
	      pc = (Function) read_error;

	   }
	 else
	   {
	      k_reg =
		 PJScheme.make_cont4 ((object) symbol ("<cont4-5>"),
				      (object) src_reg, (object) handler_reg,
				      (object) k_reg);
	      pc = (Function) read_asexp;

	   }
      }

   }

   new public static void read_asexp_sequence ()
   {
      {
	 object temp_1 = null;
	 temp_1 = PJScheme.first ((object) tokens_reg);
	 if (true_q
	     (PJScheme.
	      memq ((object) PJScheme.car ((object) temp_1),
		    (object) PJScheme.list ((object) symbol ("rparen"),
					    (object) symbol ("rbracket")))))
	   {
	      asexps_reg = EmptyList;
	      pc = (Function) close_asexp_sequence;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("dot"))))
	   {
	      msg_reg = "unexpected dot (.)";
	      pc = (Function) read_error;

	   }
	 else
	   {
	      k_reg =
		 PJScheme.make_cont4 ((object) symbol ("<cont4-7>"),
				      (object) expected_terminator_reg,
				      (object) src_reg, (object) handler_reg,
				      (object) k_reg);
	      pc = (Function) read_asexp;

	   }
      }

   }

   new public static void close_asexp_sequence ()
   {
      {
	 object end = null;
	 end =
	    PJScheme.get_token_end ((object) PJScheme.
				    first ((object) tokens_reg));
	 {
	    object temp_1 = null;
	    temp_1 = PJScheme.first ((object) tokens_reg);
	    if (true_q
		(PJScheme.
		 memq ((object) PJScheme.car ((object) temp_1),
		       (object) PJScheme.list ((object) symbol ("rparen"),
					       (object)
					       symbol ("rbracket")))))
	       if (true_q
		   (PJScheme.
		    token_type_q ((object) PJScheme.
				  first ((object) tokens_reg),
				  (object) expected_terminator_reg)))
		 {
		    value4_reg = fail_reg;
		    value3_reg = PJScheme.rest_of ((object) tokens_reg);
		    value2_reg = end;
		    value1_reg = asexps_reg;
		    pc = (Function) apply_cont4;

		 }
	       else
		  if (true_q
		      (PJScheme.
		       Eq ((object) expected_terminator_reg,
			   (object) symbol ("rparen"))))
		 {
		    msg_reg = "parenthesized list terminated by bracket";
		    pc = (Function) read_error;

		 }
	       else
		  if (true_q
		      (PJScheme.
		       Eq ((object) expected_terminator_reg,
			   (object) symbol ("rbracket"))))
		 {
		    msg_reg = "bracketed list terminated by parenthesis";
		    pc = (Function) read_error;

		 }
	       else
		  pc = (Function) unexpected_token_error;
	 }
      }

   }

   new public static object binding_variable (object binding)
   {
      return ((object) PJScheme.car ((object) binding));
   }

   new public static object binding_docstring (object binding)
   {
      return ((object) PJScheme.cadr ((object) binding));
   }

   new public static object binding_value (object binding)
   {
      return ((object) PJScheme.caddr ((object) binding));
   }

   new public static void set_binding_docstring_b (object binding,
						   object docstring)
   {
      PJScheme.set_car_b ((object) PJScheme.cdr ((object) binding),
			  (object) docstring);
   }

   new public static void set_binding_value_b (object binding, object value)
   {
      PJScheme.set_car_b ((object) PJScheme.cddr ((object) binding),
			  (object) value);
   }

   new public static object make_frame (object variables, object values)
   {
      return ((object)
	      map (make_binding_proc, (object) variables, (object) values));
   }

   new public static object first_binding (object frame)
   {
      return ((object) PJScheme.car ((object) frame));
   }

   new public static object rest_of_bindings (object frame)
   {
      return ((object) PJScheme.cdr ((object) frame));
   }

   new public static bool empty_frame_q (object frame)
   {
      return ((bool) PJScheme.null_q ((object) frame));
   }

   new public static object search_frame (object frame, object variable)
   {
      if (true_q (PJScheme.empty_frame_q ((object) frame)))
	 return ((object) false);
      else
	 if (true_q
	     (PJScheme.
	      Eq ((object) PJScheme.
		  binding_variable ((object) PJScheme.
				    first_binding ((object) frame)),
		  (object) variable)))
	 return ((object) PJScheme.first_binding ((object) frame));
      else
	 return ((object) PJScheme.
		 search_frame ((object) PJScheme.
			       rest_of_bindings ((object) frame),
			       (object) variable));
   }

   new public static bool environment_q (object x)
   {
      return ((bool)
	      (((bool) PJScheme.pair_q ((object) x))
	       && ((bool) PJScheme.
		   Eq ((object) PJScheme.car ((object) x),
		       (object) symbol ("environment")))));
   }

   new public static object make_empty_environment ()
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("environment"),
		    (object) PJScheme.list ((object) EmptyList)));
   }

   new public static object make_initial_environment (object vars,
						      object vals)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("environment"),
		    (object) PJScheme.list ((object) PJScheme.
					    make_frame ((object) vars,
							(object) vals))));
   }

   new public static object frames (object env)
   {
      return ((object) PJScheme.cdr ((object) env));
   }

   new public static object extend (object env, object variables,
				    object values)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("environment"),
		    (object) PJScheme.cons ((object) PJScheme.
					    make_frame ((object) variables,
							(object) values),
					    (object) PJScheme.
					    cdr ((object) env))));
   }

   new public static object search_env (object env, object variable)
   {
      return ((object) PJScheme.
	      search_frames ((object) PJScheme.cdr ((object) env),
			     (object) variable));
   }

   new public static object search_frames (object frames, object variable)
   {
      if (true_q (PJScheme.null_q ((object) frames)))
	 return ((object) false);
      else
	{
	   object binding = null;
	   binding =
	      PJScheme.search_frame ((object) PJScheme.car ((object) frames),
				     (object) variable);
	   if (true_q (binding))
	      return ((object) binding);
	   else
	      return ((object) PJScheme.
		      search_frames ((object) PJScheme.cdr ((object) frames),
				     (object) variable));
	}

   }

   new public static void lookup_value ()
   {
      k_reg =
	 PJScheme.make_cont2 ((object) symbol ("<cont2-3>"), (object) k_reg);
      pc = (Function) lookup_binding;

   }

   new public static void lookup_binding ()
   {
      {
	 object binding = null;
	 binding =
	    PJScheme.search_env ((object) env_reg, (object) variable_reg);
	 if (true_q (binding))
	   {
	      value2_reg = fail_reg;
	      value1_reg = binding;
	      pc = (Function) apply_cont2;

	   }
	 else
	   {
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-4>"),
				      (object) var_info_reg,
				      (object) variable_reg, (object) env_reg,
				      (object) handler_reg, (object) k_reg);
	      pc = (Function) split_variable;

	   }
      }

   }

   new public static void lookup_binding_in_first_frame ()
   {
      {
	 object frame = null;
	 frame = PJScheme.first_frame ((object) env_reg);
	 {
	    object binding = null;
	    binding =
	       PJScheme.search_frame ((object) frame, (object) var_reg);
	    if (true_q (binding))
	      {
		 value2_reg = fail_reg;
		 value1_reg = binding;
		 pc = (Function) apply_cont2;

	      }
	    else
	      {
		 object new_binding = null;
		 new_binding =
		    PJScheme.make_binding ((object) var_reg,
					   (object) symbol ("undefined"));
		 {
		    object new_frame = null;
		    new_frame =
		       PJScheme.cons ((object) new_binding, (object) frame);
		    PJScheme.set_first_frame_b ((object) env_reg,
						(object) new_frame);
		    value2_reg = fail_reg;
		    value1_reg = new_binding;
		    pc = (Function) apply_cont2;
		 }
	      }
	 }
      }

   }

   new public static void lookup_variable_components ()
   {
      {
	 object var = null;
	 var = PJScheme.car ((object) components_reg);
	 k_reg =
	    PJScheme.make_cont2 ((object) symbol ("<cont2-5>"),
				 (object) components_reg, (object) path_reg,
				 (object) var, (object) handler_reg,
				 (object) k_reg);
	 var_reg = var;
	 pc = (Function) lookup_module_binding;
      }

   }

   new public static void lookup_module_binding ()
   {
      {
	 object binding = null;
	 binding = PJScheme.search_env ((object) env_reg, (object) var_reg);
	 if (true_q (binding))
	   {
	      value2_reg = fail_reg;
	      value1_reg = binding;
	      pc = (Function) apply_cont2;

	   }
	 else if (true_q (PJScheme.dlr_env_contains ((object) var_reg)))
	   {
	      value2_reg = fail_reg;
	      value1_reg = PJScheme.dlr_env_lookup ((object) var_reg);
	      pc = (Function) apply_cont2;

	   }
	 else
	    if (true_q
		(PJScheme.string_is__q ((object) path_reg, (object) "")))
	   {
	      exception_reg =
		 PJScheme.format ((object) "unbound module '~a'",
				  (object) var_reg);
	      pc = (Function) apply_handler2;

	   }
	 else
	   {
	      exception_reg =
		 PJScheme.
		 format ((object) "unbound variable '~a' in module '~a'",
			 (object) var_reg, (object) path_reg);
	      pc = (Function) apply_handler2;

	   }
      }

   }

   new public static void split_variable ()
   {
      {
	 object strings = null;
	 strings =
	    PJScheme.group ((object) PJScheme.
			    string_to_list ((object) PJScheme.
					    symbol_to_string ((object)
							      variable_reg)),
			    (object) '.');
	 if (true_q
	     ((((bool) PJScheme.member ((object) "", (object) strings))
	       || ((bool) PJScheme.
		   EqualSign ((object) PJScheme.length ((object) strings),
			      (object) 1)))))
	   {
	      value2_reg = fail_reg;
	      value1_reg = false;
	      pc = (Function) apply_cont2;

	   }
	 else
	   {
	      value2_reg = fail_reg;
	      value1_reg = map (string_to_symbol_proc, (object) strings);
	      pc = (Function) apply_cont2;

	   }
      }

   }

   new public static bool pattern_macro_q (object x)
   {
      return ((bool)
	      (((bool) PJScheme.pair_q ((object) x))
	       && ((bool) PJScheme.
		   Eq ((object) PJScheme.car ((object) x),
		       (object) symbol ("pattern-macro")))));
   }

   new public static void macro_error ()
   {
      throw new
	 Exception (format
		    (transformer_name_reg + ": " + "bad concrete syntax: ~a",
		     datum_reg));
   }

   new public static object head (object formals)
   {
      if (true_q (PJScheme.symbol_q ((object) formals)))
	 return ((object) EmptyList);
      else
	 if (true_q
	     (PJScheme.pair_q ((object) PJScheme.cdr ((object) formals))))
	 return ((object) PJScheme.
		 cons ((object) PJScheme.car ((object) formals),
		       (object) PJScheme.head ((object) PJScheme.
					       cdr ((object) formals))));
      else
	 return ((object) PJScheme.
		 list ((object) PJScheme.car ((object) formals)));
   }

   new public static object last (object formals)
   {
      if (true_q (PJScheme.symbol_q ((object) formals)))
	 return ((object) formals);
      else
	 if (true_q
	     (PJScheme.pair_q ((object) PJScheme.cdr ((object) formals))))
	 return ((object) PJScheme.
		 last ((object) PJScheme.cdr ((object) formals)));
      else
	 return ((object) PJScheme.cdr ((object) formals));
   }

   new public static bool literal_q (object datum)
   {
      return ((bool)
	      (((bool) PJScheme.number_q ((object) datum))
	       || ((bool) PJScheme.boolean_q ((object) datum))
	       || ((bool) PJScheme.char_q ((object) datum))
	       || ((bool) PJScheme.string_q ((object) datum))));
   }

   new public static bool anything_q (object datum)
   {
      return ((bool) true);
   }

   new public static object get_reserved_keywords ()
   {
      return ((object) PJScheme.
	      list ((object) symbol ("quote"), (object) symbol ("func"),
		    (object) symbol ("define!"),
		    (object) symbol ("quasiquote"),
		    (object) symbol ("lambda"), (object) symbol ("if"),
		    (object) symbol ("set!"), (object) symbol ("define"),
		    (object) symbol ("begin"), (object) symbol ("cond"),
		    (object) symbol ("and"), (object) symbol ("or"),
		    (object) symbol ("let"), (object) symbol ("let*"),
		    (object) symbol ("letrec"), (object) symbol ("case"),
		    (object) symbol ("record-case"), (object) symbol ("try"),
		    (object) symbol ("catch"), (object) symbol ("finally"),
		    (object) symbol ("raise"), (object) symbol ("dict"),
		    (object) symbol ("help"), (object) symbol ("choose")));
   }

   new public static bool reserved_keyword_q (object x)
   {
      return ((bool)
	      (((bool) PJScheme.symbol_q ((object) x))
	       && ((bool) PJScheme.
		   memq ((object) x,
			 (object) PJScheme.get_reserved_keywords ()))));
   }

   new public static void create_letrec_assignments_hat ()
   {
      if (true_q (PJScheme.null_q ((object) vars_reg)))
	{
	   value2_reg = EmptyList;
	   value1_reg = EmptyList;
	   k_reg = k2_reg;
	   pc = (Function) apply_cont2;

	}
      else
	{
	   k2_reg =
	      PJScheme.make_cont2 ((object) symbol ("<cont2-7>"),
				   (object) procs_reg, (object) vars_reg,
				   (object) k2_reg);
	   procs_reg = PJScheme.cdr ((object) procs_reg);
	   vars_reg = PJScheme.cdr ((object) vars_reg);
	   pc = (Function) create_letrec_assignments_hat;

	}

   }

   new public static void nest_let_star_bindings_hat ()
   {
      if (true_q
	  ((((bool) PJScheme.null_q ((object) bindings_reg))
	    || ((bool) PJScheme.
		null_q ((object) PJScheme.cdr ((object) bindings_reg))))))
	{
	   value_reg =
	      PJScheme.append ((object) PJScheme.
			       list ((object) symbol ("let")),
			       (object) PJScheme.append ((object) PJScheme.
							 list ((object)
							       bindings_reg),
							 (object)
							 bodies_reg));
	   pc = (Function) apply_cont;

	}
      else
	{
	   k_reg =
	      PJScheme.make_cont ((object) symbol ("<cont-9>"),
				  (object) bindings_reg, (object) k_reg);
	   bindings_reg = PJScheme.cdr ((object) bindings_reg);
	   pc = (Function) nest_let_star_bindings_hat;

	}

   }

   new public static void case_clauses_to_simple_cond_clauses_hat ()
   {
      if (true_q (PJScheme.null_q ((object) clauses_reg)))
	{
	   value_reg = EmptyList;
	   pc = (Function) apply_cont;

	}
      else
	{
	   k_reg =
	      PJScheme.make_cont ((object) symbol ("<cont-10>"),
				  (object) clauses_reg, (object) var_reg,
				  (object) k_reg);
	   clauses_reg = PJScheme.cdr ((object) clauses_reg);
	   pc = (Function) case_clauses_to_simple_cond_clauses_hat;

	}

   }

   new public static void case_clauses_to_cond_clauses_hat ()
   {
      if (true_q (PJScheme.null_q ((object) clauses_reg)))
	{
	   value2_reg = EmptyList;
	   value1_reg = EmptyList;
	   k_reg = k2_reg;
	   pc = (Function) apply_cont2;

	}
      else
	{
	   k2_reg =
	      PJScheme.make_cont2 ((object) symbol ("<cont2-9>"),
				   (object) clauses_reg, (object) var_reg,
				   (object) k2_reg);
	   clauses_reg = PJScheme.cdr ((object) clauses_reg);
	   pc = (Function) case_clauses_to_cond_clauses_hat;

	}

   }

   new public static void record_case_clauses_to_cond_clauses_hat ()
   {
      if (true_q (PJScheme.null_q ((object) clauses_reg)))
	{
	   value2_reg = EmptyList;
	   value1_reg = EmptyList;
	   k_reg = k2_reg;
	   pc = (Function) apply_cont2;

	}
      else
	{
	   k2_reg =
	      PJScheme.make_cont2 ((object) symbol ("<cont2-10>"),
				   (object) clauses_reg, (object) var_reg,
				   (object) k2_reg);
	   clauses_reg = PJScheme.cdr ((object) clauses_reg);
	   pc = (Function) record_case_clauses_to_cond_clauses_hat;

	}

   }

   new public static object define_datatype_variant_names (object variants)
   {
      if (true_q (PJScheme.null_q ((object) variants)))
	 return ((object) EmptyList);
      else
	 return ((object) PJScheme.
		 cons ((object) PJScheme.
		       get_sexp ((object) PJScheme.
				 car_hat ((object) PJScheme.
					  car ((object) variants))),
		       (object) PJScheme.
		       define_datatype_variant_names ((object) PJScheme.
						      cdr ((object)
							   variants))));
   }

   new public static object define_datatype_variant_tests (object variants)
   {
      if (true_q (PJScheme.null_q ((object) variants)))
	 return ((object) EmptyList);
      else
	 if (true_q
	     (PJScheme.
	      null_q ((object) PJScheme.
		      cdr_hat ((object) PJScheme.car ((object) variants)))))
	 return ((object) PJScheme.
		 cons ((object) EmptyList,
		       (object) PJScheme.
		       define_datatype_variant_tests ((object) PJScheme.
						      cdr ((object)
							   variants))));
      else
	 return ((object) PJScheme.
		 cons ((object) PJScheme.
		       get_sexp ((object) PJScheme.
				 cadr_hat ((object) PJScheme.
					   cadr_hat ((object) PJScheme.
						     car ((object)
							  variants)))),
		       (object) PJScheme.
		       define_datatype_variant_tests ((object) PJScheme.
						      cdr ((object)
							   variants))));
   }

   new public static object make_define_datatype_defines (object names,
							  object tests)
   {
      if (true_q (PJScheme.null_q ((object) names)))
	 return ((object) EmptyList);
      else
	 if (true_q
	     (PJScheme.null_q ((object) PJScheme.car ((object) tests))))
	 return ((object) PJScheme.
		 cons ((object) PJScheme.
		       append ((object) PJScheme.
			       list ((object) symbol ("define")),
			       (object) PJScheme.append ((object) PJScheme.
							 list ((object)
							       PJScheme.
							       car ((object)
								    names)),
							 (object) PJScheme.
							 list ((object)
							       PJScheme.
							       append ((object) PJScheme.list ((object) symbol ("lambda")), (object) PJScheme.append ((object) PJScheme.list ((object) symbol ("args")), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("cons")), (object) PJScheme.append ((object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("quote")), (object) PJScheme.list ((object) PJScheme.car ((object) names)))), (object) PJScheme.list ((object) symbol ("args")))))))))), (object) PJScheme.make_define_datatype_defines ((object) PJScheme.cdr ((object) names), (object) PJScheme.cdr ((object) tests))));
      else
	 return ((object) PJScheme.
		 cons ((object) PJScheme.
		       append ((object) PJScheme.
			       list ((object) symbol ("define")),
			       (object) PJScheme.append ((object) PJScheme.
							 list ((object)
							       PJScheme.
							       car ((object)
								    names)),
							 (object) PJScheme.
							 list ((object)
							       PJScheme.
							       append ((object) PJScheme.list ((object) symbol ("lambda")), (object) PJScheme.append ((object) PJScheme.list ((object) symbol ("args")), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("if")), (object) PJScheme.append ((object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("apply")), (object) PJScheme.append ((object) PJScheme.list ((object) PJScheme.car ((object) tests)), (object) PJScheme.list ((object) symbol ("args"))))), (object) PJScheme.append ((object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("cons")), (object) PJScheme.append ((object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("quote")), (object) PJScheme.list ((object) PJScheme.car ((object) names)))), (object) PJScheme.list ((object) symbol ("args"))))), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("error")), (object) PJScheme.append ((object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("quote")), (object) PJScheme.list ((object) PJScheme.car ((object) names)))), (object) PJScheme.append ((object) PJScheme.list ((object) "'~s' not a valid value"), (object) PJScheme.list ((object) PJScheme.append ((object) PJScheme.list ((object) symbol ("car")), (object) PJScheme.list ((object) symbol ("args"))))))))))))))))), (object) PJScheme.make_define_datatype_defines ((object) PJScheme.cdr ((object) names), (object) PJScheme.cdr ((object) tests))));
   }

   new public static object make_macro_env_hat ()
   {
      return ((object) PJScheme.
	      make_initial_environment ((object) PJScheme.
					list ((object) symbol ("and"),
					      (object) symbol ("or"),
					      (object) symbol ("cond"),
					      (object) symbol ("let"),
					      (object) symbol ("letrec"),
					      (object) symbol ("let*"),
					      (object) symbol ("case"),
					      (object) symbol ("record-case"),
					      (object)
					      symbol ("define-datatype"),
					      (object) symbol ("cases")),
					(object) PJScheme.
					list ((object) and_transformer_hat,
					      (object) or_transformer_hat,
					      (object) cond_transformer_hat,
					      (object) let_transformer_hat,
					      (object) letrec_transformer_hat,
					      (object)
					      let_star_transformer_hat,
					      (object) case_transformer_hat,
					      (object)
					      record_case_transformer_hat,
					      (object)
					      define_datatype_transformer_hat,
					      (object)
					      cases_transformer_hat)));
   }

   new public static void amacro_error ()
   {
      k_reg =
	 PJScheme.make_cont ((object) symbol ("<cont-11>"),
			     (object) transformer_name_reg);
      x_reg = adatum_reg;
      pc = (Function) unannotate_cps;

   }

   new public static object make_pattern_macro_hat (object clauses,
						    object aclauses)
   {
      return ((object) PJScheme.
	      list ((object) symbol ("pattern-macro"), (object) clauses,
		    (object) aclauses));
   }

   new public static object macro_clauses_hat (object macro)
   {
      return ((object) PJScheme.cadr ((object) macro));
   }

   new public static object macro_aclauses_hat (object macro)
   {
      return ((object) PJScheme.caddr ((object) macro));
   }

   new public static object application_q_hat (object asexp)
   {
      return ((object)
	      (((bool) PJScheme.list_q_hat ((object) asexp))
	       && ((bool) PJScheme.
		   not ((object) PJScheme.null_q_hat ((object) asexp)))
	       && ((bool) PJScheme.
		   not ((object) PJScheme.
			reserved_keyword_q ((object) PJScheme.
					    get_sexp ((object) PJScheme.
						      car_hat ((object)
							       asexp)))))));
   }

   new public static object mit_style_q_hat (object asexp)
   {
      return ((object) PJScheme.
	      not ((object) PJScheme.
		   symbol_q_hat ((object) PJScheme.
				 cadr_hat ((object) asexp))));
   }

   new public static object literal_q_hat (object asexp)
   {
      {
	 object s = null;
	 s = PJScheme.get_sexp ((object) asexp);
	 return ((object)
		 (((bool) PJScheme.number_q ((object) s))
		  || ((bool) PJScheme.boolean_q ((object) s))
		  || ((bool) PJScheme.char_q ((object) s))
		  || ((bool) PJScheme.string_q ((object) s))));
      }

   }

   new public static object syntactic_sugar_q_hat (object asexp)
   {
      return ((object)
	      (((bool) PJScheme.pair_q_hat ((object) asexp))
	       && ((bool) PJScheme.
		   symbol_q_hat ((object) PJScheme.car_hat ((object) asexp)))
	       && ((bool) PJScheme.
		   true_q ((object) PJScheme.
			   search_env ((object) macro_env,
				       (object) PJScheme.
				       get_sexp ((object) PJScheme.
						 car_hat ((object)
							  asexp)))))));
   }

   new public static object try_body_hat (object x)
   {
      return ((object) PJScheme.cadr_hat ((object) x));
   }

   new public static object catch_var_hat (object x)
   {
      return ((object) PJScheme.cadr_hat ((object) x));
   }

   new public static object catch_exps_hat (object x)
   {
      return ((object) PJScheme.cddr_hat ((object) x));
   }

   new public static object finally_exps_hat (object x)
   {
      return ((object) PJScheme.
	      cdr ((object) PJScheme.get_sexp ((object) x)));
   }

   new public static void aparse ()
   {
      {
	 object info = null;
	 info = PJScheme.get_source_info ((object) adatum_reg);
	 if (true_q (PJScheme.null_q_hat ((object) adatum_reg)))
	   {
	      value2_reg = fail_reg;
	      value1_reg =
		 PJScheme.lit_aexp ((object) PJScheme.
				    get_sexp ((object) adatum_reg),
				    (object) info);
	      pc = (Function) apply_cont2;

	   }
	 else if (true_q (PJScheme.literal_q_hat ((object) adatum_reg)))
	   {
	      value2_reg = fail_reg;
	      value1_reg =
		 PJScheme.lit_aexp ((object) PJScheme.
				    get_sexp ((object) adatum_reg),
				    (object) info);
	      pc = (Function) apply_cont2;

	   }
	 else if (true_q (PJScheme.vector_q_hat ((object) adatum_reg)))
	   {
	      k_reg =
		 PJScheme.make_cont ((object) symbol ("<cont-18>"),
				     (object) info, (object) fail_reg,
				     (object) k_reg);
	      x_reg = adatum_reg;
	      pc = (Function) unannotate_cps;

	   }
	 else if (true_q (PJScheme.symbol_q_hat ((object) adatum_reg)))
	   {
	      value2_reg = fail_reg;
	      value1_reg =
		 PJScheme.var_aexp ((object) PJScheme.
				    get_sexp ((object) adatum_reg),
				    (object) info);
	      pc = (Function) apply_cont2;

	   }
	 else if (true_q (PJScheme.quote_q_hat ((object) adatum_reg)))
	   {
	      k_reg =
		 PJScheme.make_cont ((object) symbol ("<cont-18>"),
				     (object) info, (object) fail_reg,
				     (object) k_reg);
	      x_reg = PJScheme.cadr_hat ((object) adatum_reg);
	      pc = (Function) unannotate_cps;

	   }
	 else if (true_q (PJScheme.quasiquote_q_hat ((object) adatum_reg)))
	   {
	      k_reg =
		 PJScheme.make_cont ((object) symbol ("<cont-17>"),
				     (object) adatum_reg,
				     (object) handler_reg, (object) fail_reg,
				     (object) k_reg);
	      depth_reg = 0;
	      ax_reg = PJScheme.cadr_hat ((object) adatum_reg);
	      pc = (Function) qq_expand_cps;

	   }
	 else if (true_q (PJScheme.unquote_q_hat ((object) adatum_reg)))
	   {
	      msg_reg = "misplaced";
	      pc = (Function) aparse_error;

	   }
	 else
	    if (true_q
		(PJScheme.unquote_splicing_q_hat ((object) adatum_reg)))
	   {
	      msg_reg = "misplaced";
	      pc = (Function) aparse_error;

	   }
	 else
	    if (true_q (PJScheme.syntactic_sugar_q_hat ((object) adatum_reg)))
	   {
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-37>"),
				      (object) handler_reg, (object) k_reg);
	      pc = (Function) expand_once_hat;

	   }
	 else if (true_q (PJScheme.if_then_q_hat ((object) adatum_reg)))
	   {
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-36>"),
				      (object) adatum_reg, (object) info,
				      (object) handler_reg, (object) k_reg);
	      adatum_reg = PJScheme.cadr_hat ((object) adatum_reg);
	      pc = (Function) aparse;

	   }
	 else if (true_q (PJScheme.if_else_q_hat ((object) adatum_reg)))
	   {
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-34>"),
				      (object) adatum_reg, (object) info,
				      (object) handler_reg, (object) k_reg);
	      adatum_reg = PJScheme.cadr_hat ((object) adatum_reg);
	      pc = (Function) aparse;

	   }
	 else if (true_q (PJScheme.assignment_q_hat ((object) adatum_reg)))
	   {
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-31>"),
				      (object) adatum_reg, (object) info,
				      (object) k_reg);
	      adatum_reg = PJScheme.caddr_hat ((object) adatum_reg);
	      pc = (Function) aparse;

	   }
	 else if (true_q (PJScheme.func_q_hat ((object) adatum_reg)))
	   {
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-30>"),
				      (object) info, (object) k_reg);
	      adatum_reg = PJScheme.cadr_hat ((object) adatum_reg);
	      pc = (Function) aparse;

	   }
	 else if (true_q (PJScheme.define_q_hat ((object) adatum_reg)))
	    if (true_q (PJScheme.mit_style_q_hat ((object) adatum_reg)))
	      {
		 k_reg =
		    PJScheme.make_cont ((object) symbol ("<cont-15>"),
					(object) info, (object) handler_reg,
					(object) fail_reg, (object) k_reg);
		 datum_reg = adatum_reg;
		 macro_reg = mit_define_transformer_hat;
		 pc = (Function) apply_macro;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    EqualSign ((object) PJScheme.
			       length_hat ((object) adatum_reg), (object) 3)))
	      {
		 k_reg =
		    PJScheme.make_cont2 ((object) symbol ("<cont2-29>"),
					 (object) adatum_reg, (object) info,
					 (object) k_reg);
		 adatum_reg = PJScheme.caddr_hat ((object) adatum_reg);
		 pc = (Function) aparse;

	      }
	    else
	       if (true_q
		   ((((bool) PJScheme.
		      EqualSign ((object) PJScheme.
				 length_hat ((object) adatum_reg),
				 (object) 4))
		     && ((bool) PJScheme.
			 string_q_hat ((object) PJScheme.
				       caddr_hat ((object) adatum_reg))))))
	      {
		 k_reg =
		    PJScheme.make_cont2 ((object) symbol ("<cont2-28>"),
					 (object) adatum_reg, (object) info,
					 (object) k_reg);
		 adatum_reg = PJScheme.cadddr_hat ((object) adatum_reg);
		 pc = (Function) aparse;

	      }
	    else
	      {
		 msg_reg = "bad concrete syntax:";
		 pc = (Function) aparse_error;

	      }
	 else if (true_q (PJScheme.define_b_q_hat ((object) adatum_reg)))
	    if (true_q (PJScheme.mit_style_q_hat ((object) adatum_reg)))
	      {
		 k_reg =
		    PJScheme.make_cont ((object) symbol ("<cont-15>"),
					(object) info, (object) handler_reg,
					(object) fail_reg, (object) k_reg);
		 datum_reg = adatum_reg;
		 macro_reg = mit_define_transformer_hat;
		 pc = (Function) apply_macro;

	      }
	    else
	       if (true_q
		   (PJScheme.
		    EqualSign ((object) PJScheme.
			       length_hat ((object) adatum_reg), (object) 3)))
	      {
		 k_reg =
		    PJScheme.make_cont2 ((object) symbol ("<cont2-27>"),
					 (object) adatum_reg, (object) info,
					 (object) k_reg);
		 adatum_reg = PJScheme.caddr_hat ((object) adatum_reg);
		 pc = (Function) aparse;

	      }
	    else
	       if (true_q
		   ((((bool) PJScheme.
		      EqualSign ((object) PJScheme.
				 length_hat ((object) adatum_reg),
				 (object) 4))
		     && ((bool) PJScheme.
			 string_q_hat ((object) PJScheme.
				       caddr_hat ((object) adatum_reg))))))
	      {
		 k_reg =
		    PJScheme.make_cont2 ((object) symbol ("<cont2-26>"),
					 (object) adatum_reg, (object) info,
					 (object) k_reg);
		 adatum_reg = PJScheme.cadddr_hat ((object) adatum_reg);
		 pc = (Function) aparse;

	      }
	    else
	      {
		 msg_reg = "bad concrete syntax:";
		 pc = (Function) aparse_error;

	      }
	 else if (true_q (PJScheme.define_syntax_q_hat ((object) adatum_reg)))
	   {
	      object name = null;
	      object aclauses = null;
	      aclauses = PJScheme.cddr_hat ((object) adatum_reg);
	      name =
		 PJScheme.get_sexp ((object) PJScheme.
				    cadr_hat ((object) adatum_reg));
	      k_reg =
		 PJScheme.make_cont ((object) symbol ("<cont-13>"),
				     (object) aclauses, (object) name,
				     (object) info, (object) fail_reg,
				     (object) k_reg);
	      x_reg = aclauses;
	      pc = (Function) unannotate_cps;
	   }
	 else if (true_q (PJScheme.begin_q_hat ((object) adatum_reg)))
	   {
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-25>"),
				      (object) adatum_reg, (object) info,
				      (object) handler_reg, (object) k_reg);
	      adatum_list_reg = PJScheme.cdr_hat ((object) adatum_reg);
	      pc = (Function) aparse_all;

	   }
	 else if (true_q (PJScheme.lambda_q_hat ((object) adatum_reg)))
	   {
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-24>"),
				      (object) adatum_reg, (object) info,
				      (object) k_reg);
	      adatum_list_reg = PJScheme.cddr_hat ((object) adatum_reg);
	      pc = (Function) aparse_all;

	   }
	 else if (true_q (PJScheme.try_q_hat ((object) adatum_reg)))
	    if (true_q
		(PJScheme.
		 EqualSign ((object) PJScheme.
			    length_hat ((object) adatum_reg), (object) 2)))
	      {
		 adatum_reg = PJScheme.try_body_hat ((object) adatum_reg);
		 pc = (Function) aparse;

	      }
	    else
	       if (true_q
		   ((((bool) PJScheme.
		      EqualSign ((object) PJScheme.
				 length_hat ((object) adatum_reg),
				 (object) 3))
		     && ((bool) PJScheme.
			 catch_q_hat ((object) PJScheme.
				      caddr_hat ((object) adatum_reg))))))
	      {
		 k_reg =
		    PJScheme.make_cont2 ((object) symbol ("<cont2-23>"),
					 (object) adatum_reg, (object) info,
					 (object) handler_reg,
					 (object) k_reg);
		 adatum_reg = PJScheme.try_body_hat ((object) adatum_reg);
		 pc = (Function) aparse;

	      }
	    else
	       if (true_q
		   ((((bool) PJScheme.
		      EqualSign ((object) PJScheme.
				 length_hat ((object) adatum_reg),
				 (object) 3))
		     && ((bool) PJScheme.
			 finally_q_hat ((object) PJScheme.
					caddr_hat ((object) adatum_reg))))))
	      {
		 k_reg =
		    PJScheme.make_cont2 ((object) symbol ("<cont2-21>"),
					 (object) adatum_reg, (object) info,
					 (object) handler_reg,
					 (object) k_reg);
		 adatum_reg = PJScheme.try_body_hat ((object) adatum_reg);
		 pc = (Function) aparse;

	      }
	    else
	       if (true_q
		   ((((bool) PJScheme.
		      EqualSign ((object) PJScheme.
				 length_hat ((object) adatum_reg),
				 (object) 4))
		     && ((bool) PJScheme.
			 catch_q_hat ((object) PJScheme.
				      caddr_hat ((object) adatum_reg)))
		     && ((bool) PJScheme.
			 finally_q_hat ((object) PJScheme.
					cadddr_hat ((object) adatum_reg))))))
	      {
		 k_reg =
		    PJScheme.make_cont2 ((object) symbol ("<cont2-19>"),
					 (object) adatum_reg, (object) info,
					 (object) handler_reg,
					 (object) k_reg);
		 adatum_reg = PJScheme.try_body_hat ((object) adatum_reg);
		 pc = (Function) aparse;

	      }
	    else
	      {
		 msg_reg = "bad try syntax:";
		 pc = (Function) aparse_error;

	      }
	 else if (true_q (PJScheme.raise_q_hat ((object) adatum_reg)))
	   {
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-16>"),
				      (object) info, (object) k_reg);
	      adatum_reg = PJScheme.cadr_hat ((object) adatum_reg);
	      pc = (Function) aparse;

	   }
	 else if (true_q (PJScheme.dict_q_hat ((object) adatum_reg)))
	   {
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-15>"),
				      (object) info, (object) k_reg);
	      entries_reg = PJScheme.cdr_hat ((object) adatum_reg);
	      pc = (Function) aparse_entries;

	   }
	 else if (true_q (PJScheme.help_q_hat ((object) adatum_reg)))
	    if (true_q
		(PJScheme.
		 symbol_q_hat ((object) PJScheme.
			       cadr_hat ((object) adatum_reg))))
	      {
		 object var = null;
		 object var_info = null;
		 var_info =
		    PJScheme.get_source_info ((object) PJScheme.
					      cadr_hat ((object) adatum_reg));
		 var =
		    PJScheme.get_sexp ((object) PJScheme.
				       cadr_hat ((object) adatum_reg));
		 value2_reg = fail_reg;
		 value1_reg =
		    PJScheme.help_aexp ((object) var, (object) var_info,
					(object) info);
		 pc = (Function) apply_cont2;
	      }
	    else
	      {
		 msg_reg = "bad concrete syntax:";
		 pc = (Function) aparse_error;

	      }
	 else if (true_q (PJScheme.choose_q_hat ((object) adatum_reg)))
	   {
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-14>"),
				      (object) info, (object) k_reg);
	      adatum_list_reg = PJScheme.cdr_hat ((object) adatum_reg);
	      pc = (Function) aparse_all;

	   }
	 else if (true_q (PJScheme.application_q_hat ((object) adatum_reg)))
	   {
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-13>"),
				      (object) adatum_reg, (object) info,
				      (object) handler_reg, (object) k_reg);
	      adatum_reg = PJScheme.car_hat ((object) adatum_reg);
	      pc = (Function) aparse;

	   }
	 else
	   {
	      msg_reg = "bad concrete syntax:";
	      pc = (Function) aparse_error;

	   }
      }

   }

   new public static void aparse_error ()
   {
      {
	 object info = null;
	 info = PJScheme.get_source_info ((object) adatum_reg);
	 k_reg =
	    PJScheme.make_cont ((object) symbol ("<cont-19>"),
				(object) msg_reg, (object) info,
				(object) handler_reg, (object) fail_reg);
	 x_reg = adatum_reg;
	 pc = (Function) unannotate_cps;
      }

   }

   new public static void expand_once_hat ()
   {
      k_reg =
	 PJScheme.make_cont2 ((object) symbol ("<cont2-38>"),
			      (object) adatum_reg, (object) handler_reg,
			      (object) k_reg);
      var_info_reg = symbol ("none");
      env_reg = macro_env;
      variable_reg =
	 PJScheme.get_sexp ((object) PJScheme.car_hat ((object) adatum_reg));
      pc = (Function) lookup_value;

   }

   new public static void process_macro_clauses_hat ()
   {
      if (true_q (PJScheme.null_q ((object) clauses_reg)))
	{
	   msg_reg = "no matching clause found for";
	   pc = (Function) aparse_error;

	}
      else
	{
	   object left_pattern = null;
	   object right_pattern = null;
	   object aleft_pattern = null;
	   object aright_pattern = null;
	   aright_pattern =
	      PJScheme.cadr_hat ((object) PJScheme.
				 car ((object) aclauses_reg));
	   aleft_pattern =
	      PJScheme.car_hat ((object) PJScheme.
				car ((object) aclauses_reg));
	   right_pattern = PJScheme.cadar ((object) clauses_reg);
	   left_pattern = PJScheme.caar ((object) clauses_reg);
	   k_reg =
	      PJScheme.make_cont ((object) symbol ("<cont-23>"),
				  (object) aclauses_reg, (object) adatum_reg,
				  (object) aleft_pattern,
				  (object) aright_pattern,
				  (object) clauses_reg, (object) left_pattern,
				  (object) right_pattern,
				  (object) handler_reg, (object) fail_reg,
				  (object) k_reg);
	   x_reg = adatum_reg;
	   pc = (Function) unannotate_cps;
	}

   }

   new public static void aparse_entries ()
   {
      if (true_q (PJScheme.null_q ((object) entries_reg)))
	{
	   value2_reg = fail_reg;
	   value1_reg = EmptyList;
	   pc = (Function) apply_cont2;

	}
      else
	{
	   k_reg =
	      PJScheme.make_cont2 ((object) symbol ("<cont2-41>"),
				   (object) entries_reg, (object) handler_reg,
				   (object) k_reg);
	   adatum_list_reg =
	      PJScheme.get_sexp ((object) PJScheme.
				 car ((object) entries_reg));
	   pc = (Function) aparse_all;

	}

   }

   new public static void aparse_all ()
   {
      if (true_q (PJScheme.null_q ((object) adatum_list_reg)))
	{
	   value2_reg = fail_reg;
	   value1_reg = EmptyList;
	   pc = (Function) apply_cont2;

	}
      else
	{
	   k_reg =
	      PJScheme.make_cont2 ((object) symbol ("<cont2-42>"),
				   (object) adatum_list_reg,
				   (object) handler_reg, (object) k_reg);
	   adatum_reg = PJScheme.car ((object) adatum_list_reg);
	   pc = (Function) aparse;

	}

   }

   new public static void aparse_sexps ()
   {
      if (true_q
	  (PJScheme.
	   token_type_q ((object) PJScheme.first ((object) tokens_reg),
			 (object) symbol ("end-marker"))))
	{
	   value2_reg = fail_reg;
	   value1_reg = EmptyList;
	   pc = (Function) apply_cont2;

	}
      else
	{
	   k_reg =
	      PJScheme.make_cont4 ((object) symbol ("<cont4-8>"),
				   (object) src_reg, (object) handler_reg,
				   (object) k_reg);
	   pc = (Function) read_asexp;

	}

   }

   new public static void qq_expand_cps ()
   {
      if (true_q (PJScheme.quasiquote_q_hat ((object) ax_reg)))
	{
	   k_reg =
	      PJScheme.make_cont ((object) symbol ("<cont-28>"),
				  (object) k_reg);
	   depth_reg = PJScheme.Add ((object) depth_reg, (object) 1);
	   ax_reg = PJScheme._hatcdr_hat ((object) ax_reg);
	   pc = (Function) qq_expand_cps;

	}
      else
	 if (true_q
	     ((((bool) PJScheme.unquote_q_hat ((object) ax_reg))
	       || ((bool) PJScheme.
		   unquote_splicing_q_hat ((object) ax_reg)))))
	 if (true_q (PJScheme.GreaterThan ((object) depth_reg, (object) 0)))
	   {
	      k_reg =
		 PJScheme.make_cont ((object) symbol ("<cont-27>"),
				     (object) ax_reg, (object) k_reg);
	      depth_reg = PJScheme.Subtract ((object) depth_reg, (object) 1);
	      ax_reg = PJScheme._hatcdr_hat ((object) ax_reg);
	      pc = (Function) qq_expand_cps;

	   }
	 else
	    if (true_q
		((((bool) PJScheme.unquote_q_hat ((object) ax_reg))
		  && ((bool) PJScheme.
		      not ((object) PJScheme.
			   null_q ((object) PJScheme.
				   cdr_hat ((object) ax_reg))))
		  && ((bool) PJScheme.
		      null_q ((object) PJScheme.
			      cddr_hat ((object) ax_reg))))))
	   {
	      value_reg = PJScheme.cadr_hat ((object) ax_reg);
	      pc = (Function) apply_cont;

	   }
	 else
	   {
	      value_reg =
		 PJScheme.append ((object) PJScheme.
				  list ((object) symbol ("quote")),
				  (object) PJScheme.list ((object) ax_reg));
	      pc = (Function) apply_cont;

	   }
      else if (true_q (PJScheme.vector_q_hat ((object) ax_reg)))
	{
	   k_reg =
	      PJScheme.make_cont ((object) symbol ("<cont-26>"),
				  (object) k_reg);
	   ax_reg =
	      PJScheme.retag ((object) PJScheme.
			      vector_to_list_hat ((object) ax_reg),
			      (object) symbol ("none"));
	   pc = (Function) qq_expand_cps;

	}
      else
	 if (true_q
	     (PJScheme.not ((object) PJScheme.pair_q_hat ((object) ax_reg))))
	{
	   value_reg =
	      PJScheme.append ((object) PJScheme.
			       list ((object) symbol ("quote")),
			       (object) PJScheme.list ((object) ax_reg));
	   pc = (Function) apply_cont;

	}
      else
	 if (true_q
	     (PJScheme.null_q ((object) PJScheme.cdr_hat ((object) ax_reg))))
	{
	   ax_reg = PJScheme.car_hat ((object) ax_reg);
	   pc = (Function) qq_expand_list_cps;

	}
      else
	{
	   k_reg =
	      PJScheme.make_cont ((object) symbol ("<cont-25>"),
				  (object) ax_reg, (object) depth_reg,
				  (object) k_reg);
	   ax_reg = PJScheme.car_hat ((object) ax_reg);
	   pc = (Function) qq_expand_list_cps;

	}

   }

   new public static void qq_expand_list_cps ()
   {
      if (true_q (PJScheme.quasiquote_q_hat ((object) ax_reg)))
	{
	   k_reg =
	      PJScheme.make_cont ((object) symbol ("<cont-33>"),
				  (object) k_reg);
	   depth_reg = PJScheme.Add ((object) depth_reg, (object) 1);
	   ax_reg = PJScheme._hatcdr_hat ((object) ax_reg);
	   pc = (Function) qq_expand_cps;

	}
      else
	 if (true_q
	     ((((bool) PJScheme.unquote_q_hat ((object) ax_reg))
	       || ((bool) PJScheme.
		   unquote_splicing_q_hat ((object) ax_reg)))))
	 if (true_q (PJScheme.GreaterThan ((object) depth_reg, (object) 0)))
	   {
	      k_reg =
		 PJScheme.make_cont ((object) symbol ("<cont-32>"),
				     (object) ax_reg, (object) k_reg);
	      depth_reg = PJScheme.Subtract ((object) depth_reg, (object) 1);
	      ax_reg = PJScheme._hatcdr_hat ((object) ax_reg);
	      pc = (Function) qq_expand_cps;

	   }
	 else if (true_q (PJScheme.unquote_q_hat ((object) ax_reg)))
	   {
	      value_reg =
		 PJScheme.append ((object) PJScheme.
				  list ((object) symbol ("list")),
				  (object) PJScheme.
				  _hatcdr_hat ((object) ax_reg));
	      pc = (Function) apply_cont;

	   }
	 else
	    if (true_q
		(PJScheme.
		 null_q ((object) PJScheme.cddr_hat ((object) ax_reg))))
	   {
	      value_reg = PJScheme.cadr_hat ((object) ax_reg);
	      pc = (Function) apply_cont;

	   }
	 else
	   {
	      value_reg =
		 PJScheme.append ((object) PJScheme.
				  list ((object) symbol ("append")),
				  (object) PJScheme.
				  _hatcdr_hat ((object) ax_reg));
	      pc = (Function) apply_cont;

	   }
      else if (true_q (PJScheme.vector_q_hat ((object) ax_reg)))
	{
	   k_reg =
	      PJScheme.make_cont ((object) symbol ("<cont-31>"),
				  (object) k_reg);
	   pc = (Function) qq_expand_cps;

	}
      else
	 if (true_q
	     (PJScheme.not ((object) PJScheme.pair_q_hat ((object) ax_reg))))
	{
	   value_reg =
	      PJScheme.append ((object) PJScheme.
			       list ((object) symbol ("quote")),
			       (object) PJScheme.list ((object) PJScheme.
						       list ((object)
							     ax_reg)));
	   pc = (Function) apply_cont;

	}
      else
	 if (true_q
	     (PJScheme.null_q ((object) PJScheme.cdr_hat ((object) ax_reg))))
	{
	   k_reg =
	      PJScheme.make_cont ((object) symbol ("<cont-31>"),
				  (object) k_reg);
	   ax_reg = PJScheme.car_hat ((object) ax_reg);
	   pc = (Function) qq_expand_list_cps;

	}
      else
	{
	   k_reg =
	      PJScheme.make_cont ((object) symbol ("<cont-30>"),
				  (object) ax_reg, (object) depth_reg,
				  (object) k_reg);
	   ax_reg = PJScheme.car_hat ((object) ax_reg);
	   pc = (Function) qq_expand_list_cps;

	}

   }

   new public static bool exception_q (object x)
   {
      return ((bool)
	      (((bool) PJScheme.pair_q ((object) x))
	       && ((bool) PJScheme.
		   Eq ((object) PJScheme.car ((object) x),
		       (object) symbol ("exception")))));
   }

   new public static void execute_next_expression (object src)
   {
      k_reg = PJScheme.make_cont4 ((object) symbol ("<cont4-9>"));
      fail_reg = _starlast_fail_star;
      handler_reg = REP_handler;
      src_reg = src;
      tokens_reg = _startokens_left_star;
      pc = (Function) read_asexp;

   }

   new public static void initialize_globals ()
   {
      toplevel_env = PJScheme.make_toplevel_env ();
      macro_env = PJScheme.make_macro_env_hat ();
      load_stack = EmptyList;
      _starlast_fail_star = REP_fail;

   }

   new public static object execute_string_rm (object input)
   {
      return ((object) PJScheme.
	      execute_rm ((string) input, (object) symbol ("stdin")));
   }

   new public static object execute_file_rm (object filename)
   {
      return ((object) PJScheme.
	      execute_rm ((string) PJScheme.read_content ((object) filename),
			  (object) filename));
   }

   new public static object execute_rm (string input, object src)
   {
      load_stack = EmptyList;
      k_reg = REP_k;
      fail_reg = _starlast_fail_star;
      handler_reg = REP_handler;
      src_reg = src;
      input_reg = input;
      pc = (Function) scan_input;
      {
	 object result = null;
	 result = PJScheme.trampoline ();
	 if (true_q (PJScheme.exception_q ((object) result)))
	    return ((object) result);
	 else
	   {
	      _startokens_left_star = result;
	      if (true_q
		  (PJScheme.
		   token_type_q ((object) PJScheme.
				 first ((object) _startokens_left_star),
				 (object) symbol ("end-marker"))))
		 return ((object) void_value);
	      else
		 return ((object) PJScheme.execute_loop_rm ((object) src));
	   }
      }

   }

   new public static object execute_loop_rm (object src)
   {
      PJScheme.execute_next_expression ((object) src);
      {
	 object result = null;
	 result = PJScheme.trampoline ();
	 if (true_q
	     ((((bool) PJScheme.exception_q ((object) result))
	       || ((bool) PJScheme.end_of_session_q ((object) result))
	       || ((bool) PJScheme.
		   token_type_q ((object) PJScheme.
				 first ((object) _startokens_left_star),
				 (object) symbol ("end-marker"))))))
	    return ((object) result);
	 else
	    return ((object) PJScheme.execute_loop_rm ((object) src));
      }

   }

   new public static bool try_parse (object input)
   {
      load_stack = EmptyList;
      k_reg = PJScheme.make_cont2 ((object) symbol ("<cont2-48>"));
      fail_reg = _starlast_fail_star;
      handler_reg = try_parse_handler;
      src_reg = symbol ("stdin");
      input_reg = input;
      pc = (Function) scan_input;
      return ((bool) PJScheme.trampoline ());
   }

   new public static void read_and_eval_asexps ()
   {
      if (true_q
	  (PJScheme.
	   token_type_q ((object) PJScheme.first ((object) tokens_reg),
			 (object) symbol ("end-marker"))))
	{
	   value2_reg = fail_reg;
	   value1_reg = void_value;
	   pc = (Function) apply_cont2;

	}
      else
	{
	   k_reg =
	      PJScheme.make_cont4 ((object) symbol ("<cont4-10>"),
				   (object) src_reg, (object) env_reg,
				   (object) handler_reg, (object) k_reg);
	   pc = (Function) read_asexp;

	}

   }

   new public static object make_debugging_k (object exp, object k)
   {
      if (true_q (PJScheme.not ((object) _startracing_on_q_star)))
	 return ((object) k);
      else
	 return ((object) PJScheme.
		 make_cont2 ((object) symbol ("<cont2-51>"), (object) exp,
			     (object) k));
   }

   new public static void m ()
   {
      {
	 object k = null;
	 k = PJScheme.make_debugging_k ((object) exp_reg, (object) k_reg);
	 if (true_q
	     (PJScheme.
	      Eq ((object) PJScheme.car ((object) exp_reg),
		  (object) symbol ("lit-aexp"))))
	   {
	      object datum = null;
	      datum = PJScheme.list_ref ((object) exp_reg, (object) 1);
	      value2_reg = fail_reg;
	      value1_reg = datum;
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) exp_reg),
		     (object) symbol ("var-aexp"))))
	   {
	      object id = null;
	      object info = null;
	      info = PJScheme.list_ref ((object) exp_reg, (object) 2);
	      id = PJScheme.list_ref ((object) exp_reg, (object) 1);
	      k_reg = k;
	      var_info_reg = info;
	      variable_reg = id;
	      pc = (Function) lookup_value;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) exp_reg),
		     (object) symbol ("func-aexp"))))
	   {
	      object exp = null;
	      exp = PJScheme.list_ref ((object) exp_reg, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-65>"),
				      (object) k);
	      exp_reg = exp;
	      pc = (Function) m;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) exp_reg),
		     (object) symbol ("if-aexp"))))
	   {
	      object test_exp = null;
	      object then_exp = null;
	      object else_exp = null;
	      else_exp = PJScheme.list_ref ((object) exp_reg, (object) 3);
	      then_exp = PJScheme.list_ref ((object) exp_reg, (object) 2);
	      test_exp = PJScheme.list_ref ((object) exp_reg, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-64>"),
				      (object) else_exp, (object) then_exp,
				      (object) env_reg, (object) handler_reg,
				      (object) k);
	      exp_reg = test_exp;
	      pc = (Function) m;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) exp_reg),
		     (object) symbol ("assign-aexp"))))
	   {
	      object var = null;
	      object rhs_exp = null;
	      object var_info = null;
	      var_info = PJScheme.list_ref ((object) exp_reg, (object) 3);
	      rhs_exp = PJScheme.list_ref ((object) exp_reg, (object) 2);
	      var = PJScheme.list_ref ((object) exp_reg, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-63>"),
				      (object) var, (object) var_info,
				      (object) env_reg, (object) handler_reg,
				      (object) k);
	      exp_reg = rhs_exp;
	      pc = (Function) m;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) exp_reg),
		     (object) symbol ("define-aexp"))))
	   {
	      object var = null;
	      object docstring = null;
	      object rhs_exp = null;
	      rhs_exp = PJScheme.list_ref ((object) exp_reg, (object) 3);
	      docstring = PJScheme.list_ref ((object) exp_reg, (object) 2);
	      var = PJScheme.list_ref ((object) exp_reg, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-61>"),
				      (object) docstring, (object) var,
				      (object) env_reg, (object) handler_reg,
				      (object) k);
	      exp_reg = rhs_exp;
	      pc = (Function) m;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) exp_reg),
		     (object) symbol ("define!-aexp"))))
	   {
	      object var = null;
	      object docstring = null;
	      object rhs_exp = null;
	      rhs_exp = PJScheme.list_ref ((object) exp_reg, (object) 3);
	      docstring = PJScheme.list_ref ((object) exp_reg, (object) 2);
	      var = PJScheme.list_ref ((object) exp_reg, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-59>"),
				      (object) docstring, (object) var,
				      (object) k);
	      exp_reg = rhs_exp;
	      pc = (Function) m;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) exp_reg),
		     (object) symbol ("define-syntax-aexp"))))
	   {
	      object name = null;
	      object clauses = null;
	      object aclauses = null;
	      aclauses = PJScheme.list_ref ((object) exp_reg, (object) 3);
	      clauses = PJScheme.list_ref ((object) exp_reg, (object) 2);
	      name = PJScheme.list_ref ((object) exp_reg, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-58>"),
				      (object) aclauses, (object) clauses,
				      (object) k);
	      env_reg = macro_env;
	      var_reg = name;
	      pc = (Function) lookup_binding_in_first_frame;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) exp_reg),
		     (object) symbol ("begin-aexp"))))
	   {
	      object exps = null;
	      exps = PJScheme.list_ref ((object) exp_reg, (object) 1);
	      k_reg = k;
	      exps_reg = exps;
	      pc = (Function) eval_sequence;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) exp_reg),
		     (object) symbol ("lambda-aexp"))))
	   {
	      object formals = null;
	      object bodies = null;
	      bodies = PJScheme.list_ref ((object) exp_reg, (object) 2);
	      formals = PJScheme.list_ref ((object) exp_reg, (object) 1);
	      value2_reg = fail_reg;
	      value1_reg =
		 PJScheme.closure ((object) formals, (object) bodies,
				   (object) env_reg);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) exp_reg),
		     (object) symbol ("mu-lambda-aexp"))))
	   {
	      object formals = null;
	      object runt = null;
	      object bodies = null;
	      bodies = PJScheme.list_ref ((object) exp_reg, (object) 3);
	      runt = PJScheme.list_ref ((object) exp_reg, (object) 2);
	      formals = PJScheme.list_ref ((object) exp_reg, (object) 1);
	      value2_reg = fail_reg;
	      value1_reg =
		 PJScheme.mu_closure ((object) formals, (object) runt,
				      (object) bodies, (object) env_reg);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) exp_reg),
		     (object) symbol ("try-catch-aexp"))))
	   {
	      object body = null;
	      object cvar = null;
	      object cexps = null;
	      cexps = PJScheme.list_ref ((object) exp_reg, (object) 3);
	      cvar = PJScheme.list_ref ((object) exp_reg, (object) 2);
	      body = PJScheme.list_ref ((object) exp_reg, (object) 1);
	      {
		 object new_handler = null;
		 new_handler =
		    PJScheme.try_catch_handler ((object) cvar, (object) cexps,
						(object) env_reg,
						(object) handler_reg,
						(object) k);
		 k_reg = k;
		 handler_reg = new_handler;
		 exp_reg = body;
		 pc = (Function) m;
	      }
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) exp_reg),
		     (object) symbol ("try-finally-aexp"))))
	   {
	      object body = null;
	      object fexps = null;
	      fexps = PJScheme.list_ref ((object) exp_reg, (object) 2);
	      body = PJScheme.list_ref ((object) exp_reg, (object) 1);
	      {
		 object new_handler = null;
		 new_handler =
		    PJScheme.try_finally_handler ((object) fexps,
						  (object) env_reg,
						  (object) handler_reg);
		 k_reg =
		    PJScheme.make_cont2 ((object) symbol ("<cont2-57>"),
					 (object) fexps, (object) env_reg,
					 (object) handler_reg, (object) k);
		 handler_reg = new_handler;
		 exp_reg = body;
		 pc = (Function) m;
	      }
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) exp_reg),
		     (object) symbol ("try-catch-finally-aexp"))))
	   {
	      object body = null;
	      object cvar = null;
	      object cexps = null;
	      object fexps = null;
	      fexps = PJScheme.list_ref ((object) exp_reg, (object) 4);
	      cexps = PJScheme.list_ref ((object) exp_reg, (object) 3);
	      cvar = PJScheme.list_ref ((object) exp_reg, (object) 2);
	      body = PJScheme.list_ref ((object) exp_reg, (object) 1);
	      {
		 object new_handler = null;
		 new_handler =
		    PJScheme.try_catch_finally_handler ((object) cvar,
							(object) cexps,
							(object) fexps,
							(object) env_reg,
							(object) handler_reg,
							(object) k);
		 k_reg =
		    PJScheme.make_cont2 ((object) symbol ("<cont2-57>"),
					 (object) fexps, (object) env_reg,
					 (object) handler_reg, (object) k);
		 handler_reg = new_handler;
		 exp_reg = body;
		 pc = (Function) m;
	      }
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) exp_reg),
		     (object) symbol ("raise-aexp"))))
	   {
	      object exp = null;
	      exp = PJScheme.list_ref ((object) exp_reg, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-55>"),
				      (object) handler_reg);
	      exp_reg = exp;
	      pc = (Function) m;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) exp_reg),
		     (object) symbol ("dict-aexp"))))
	   {
	      object pairs = null;
	      pairs = PJScheme.list_ref ((object) exp_reg, (object) 1);
	      value2_reg = fail_reg;
	      value1_reg =
		 PJScheme.list ((object) symbol ("dict"), (object) pairs);
	      k_reg = k;
	      pc = (Function) apply_cont2;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) exp_reg),
		     (object) symbol ("help-aexp"))))
	   {
	      object var = null;
	      object var_info = null;
	      var_info = PJScheme.list_ref ((object) exp_reg, (object) 2);
	      var = PJScheme.list_ref ((object) exp_reg, (object) 1);
	      if (true_q (PJScheme.reserved_keyword_q ((object) var)))
		{
		   value2_reg = fail_reg;
		   value1_reg =
		      PJScheme.format ((object) "~a is a keyword",
				       (object) var);
		   k_reg = k;
		   pc = (Function) apply_cont2;

		}
	      else
		{
		   k_reg =
		      PJScheme.make_cont2 ((object) symbol ("<cont2-54>"),
					   (object) k);
		   var_info_reg = var_info;
		   variable_reg = var;
		   pc = (Function) lookup_binding;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) exp_reg),
		     (object) symbol ("choose-aexp"))))
	   {
	      object exps = null;
	      exps = PJScheme.list_ref ((object) exp_reg, (object) 1);
	      k_reg = k;
	      exps_reg = exps;
	      pc = (Function) eval_choices;
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) exp_reg),
		     (object) symbol ("app-aexp"))))
	   {
	      object rator = null;
	      object operands = null;
	      object info = null;
	      info = PJScheme.list_ref ((object) exp_reg, (object) 3);
	      operands = PJScheme.list_ref ((object) exp_reg, (object) 2);
	      rator = PJScheme.list_ref ((object) exp_reg, (object) 1);
	      k_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-53>"),
				      (object) rator, (object) env_reg,
				      (object) info, (object) handler_reg,
				      (object) k);
	      exps_reg = operands;
	      pc = (Function) m_star;
	   }
	 else
	    throw new
	       Exception (format
			  (symbol ("m") + ": " + "bad abstract syntax: ~s",
			   exp_reg));
      }

   }

   new public static void runtime_error ()
   {
      if (true_q (PJScheme.Eq ((object) info_reg, (object) symbol ("none"))))
	{
	   exception_reg =
	      PJScheme.format ((object) "runtime error: ~a",
			       (object) msg_reg);
	   pc = (Function) apply_handler2;

	}
      else
	{
	   object src = null;
	   object line = null;
	   object chr = null;
	   chr = PJScheme.get_start_char ((object) info_reg);
	   line = PJScheme.get_start_line ((object) info_reg);
	   src = PJScheme.get_srcfile ((object) info_reg);
	   exception_reg =
	      PJScheme.format ((object) "runtime error: ~a ~a",
			       (object) msg_reg,
			       (object) PJScheme.where_at ((object) line,
							   (object) chr,
							   (object) src));
	   pc = (Function) apply_handler2;
	}

   }

   new public static object try_catch_handler (object cvar, object cexps,
					       object env, object handler,
					       object k)
   {
      return ((object) PJScheme.
	      make_handler2 ((object) symbol ("<handler2-4>"), (object) cexps,
			     (object) cvar, (object) env, (object) handler,
			     (object) k));
   }

   new public static object try_finally_handler (object fexps, object env,
						 object handler)
   {
      return ((object) PJScheme.
	      make_handler2 ((object) symbol ("<handler2-5>"), (object) fexps,
			     (object) env, (object) handler));
   }

   new public static object try_catch_finally_handler (object cvar,
						       object cexps,
						       object fexps,
						       object env,
						       object handler,
						       object k)
   {
      return ((object) PJScheme.
	      make_handler2 ((object) symbol ("<handler2-6>"), (object) cexps,
			     (object) cvar, (object) fexps, (object) env,
			     (object) handler, (object) k));
   }

   new public static void eval_choices ()
   {
      if (true_q (PJScheme.null_q ((object) exps_reg)))
	 pc = (Function) apply_fail;
      else
	{
	   object new_fail = null;
	   new_fail =
	      PJScheme.make_fail ((object) symbol ("<fail-3>"),
				  (object) exps_reg, (object) env_reg,
				  (object) handler_reg, (object) fail_reg,
				  (object) k_reg);
	   fail_reg = new_fail;
	   exp_reg = PJScheme.car ((object) exps_reg);
	   pc = (Function) m;
	}

   }

   new public static object closure (object formals, object bodies,
				     object env)
   {
      return ((object) PJScheme.
	      make_proc ((object) symbol ("<proc-1>"), (object) bodies,
			 (object) formals, (object) env));
   }

   new public static object mu_closure (object formals, object runt,
					object bodies, object env)
   {
      return ((object) PJScheme.
	      make_proc ((object) symbol ("<proc-2>"), (object) bodies,
			 (object) formals, (object) runt, (object) env));
   }

   new public static void m_star ()
   {
      if (true_q (PJScheme.null_q ((object) exps_reg)))
	{
	   value2_reg = fail_reg;
	   value1_reg = EmptyList;
	   pc = (Function) apply_cont2;

	}
      else
	{
	   k_reg =
	      PJScheme.make_cont2 ((object) symbol ("<cont2-68>"),
				   (object) exps_reg, (object) env_reg,
				   (object) handler_reg, (object) k_reg);
	   exp_reg = PJScheme.car ((object) exps_reg);
	   pc = (Function) m;

	}

   }

   new public static void eval_sequence ()
   {
      k_reg =
	 PJScheme.make_cont2 ((object) symbol ("<cont2-69>"),
			      (object) exps_reg, (object) env_reg,
			      (object) handler_reg, (object) k_reg);
      exp_reg = PJScheme.car ((object) exps_reg);
      pc = (Function) m;

   }

   new public static bool length_one_q (object ls)
   {
      return ((bool)
	      (((bool) PJScheme.not ((object) PJScheme.null_q ((object) ls)))
	       && ((bool) PJScheme.
		   null_q ((object) PJScheme.cdr ((object) ls)))));
   }

   new public static bool length_two_q (object ls)
   {
      return ((bool)
	      (((bool) PJScheme.not ((object) PJScheme.null_q ((object) ls)))
	       && ((bool) PJScheme.
		   not ((object) PJScheme.
			null_q ((object) PJScheme.cdr ((object) ls))))
	       && ((bool) PJScheme.
		   null_q ((object) PJScheme.cddr ((object) ls)))));
   }

   new public static bool length_at_least_q (object n, object ls)
   {
      if (true_q (PJScheme.LessThan ((object) n, (object) 1)))
	 return ((bool) true);
      else
	 if (true_q
	     ((((bool) PJScheme.null_q ((object) ls))
	       || ((bool) PJScheme.
		   not ((object) PJScheme.pair_q ((object) ls))))))
	 return ((bool) false);
      else
	 return ((bool) PJScheme.
		 length_at_least_q ((object) PJScheme.
				    Subtract ((object) n, (object) 1),
				    (object) PJScheme.cdr ((object) ls)));
   }

   new public static bool all_numeric_q (object ls)
   {
      return ((bool)
	      (((bool) PJScheme.null_q ((object) ls))
	       ||
	       ((bool)
		(((bool) PJScheme.
		  number_q ((object) PJScheme.car ((object) ls)))
		 && ((bool) PJScheme.
		     all_numeric_q ((object) PJScheme.cdr ((object) ls)))))));
   }

   new public static bool void_q (object x)
   {
      return ((bool) PJScheme.Eq ((object) x, (object) void_value));
   }

   new public static bool end_of_session_q (object x)
   {
      return ((bool) PJScheme.Eq ((object) x, (object) end_of_session));
   }

   new public static bool procedure_object_q (object x)
   {
      return ((bool)
	      (((bool) PJScheme.procedure_q ((object) x))
	       ||
	       ((bool)
		(((bool) PJScheme.pair_q ((object) x))
		 && ((bool) PJScheme.
		     Eq ((object) PJScheme.car ((object) x),
			 (object) symbol ("procedure")))))));
   }

   new public static bool environment_object_q (object x)
   {
      return ((bool)
	      (((bool) PJScheme.pair_q ((object) x))
	       && ((bool) PJScheme.
		   Eq ((object) PJScheme.car ((object) x),
		       (object) symbol ("environment")))));
   }

   new public static bool ends_with_newline_q (string s)
   {
      {
	 object len = null;
	 len = PJScheme.string_length ((object) s);
	 return ((bool) PJScheme.
		 Equal ((object) PJScheme.
			substring ((object) s,
				   (object) PJScheme.Subtract ((object) len,
							       (object) 1),
				   (object) len), (object) "\n"));
      }

   }

   new public static void load_file ()
   {
      if (true_q
	  (PJScheme.member ((object) filename_reg, (object) load_stack)))
	{
	   PJScheme.printf ((object) "skipping recursive load of ~a~%",
			    (object) filename_reg);
	   value2_reg = fail_reg;
	   value1_reg = void_value;
	   pc = (Function) apply_cont2;

	}
      else
	 if (true_q
	     (PJScheme.
	      not ((object) PJScheme.string_q ((object) filename_reg))))
	{
	   msg_reg =
	      PJScheme.format ((object) "filename ~a is not a string",
			       (object) filename_reg);
	   pc = (Function) runtime_error;

	}
      else
	 if (true_q
	     (PJScheme.
	      not ((object) PJScheme.file_exists_q ((object) filename_reg))))
	{
	   msg_reg =
	      PJScheme.
	      format ((object) "attempted to load nonexistent file ~a",
		      (object) filename_reg);
	   pc = (Function) runtime_error;

	}
      else
	{
	   load_stack =
	      PJScheme.cons ((object) filename_reg, (object) load_stack);
	   k_reg =
	      PJScheme.make_cont2 ((object) symbol ("<cont2-74>"),
				   (object) filename_reg, (object) env_reg,
				   (object) handler_reg, (object) k_reg);
	   src_reg = filename_reg;
	   input_reg = PJScheme.read_content ((object) filename_reg);
	   pc = (Function) scan_input;

	}

   }

   new public static void load_files ()
   {
      if (true_q (PJScheme.null_q ((object) filenames_reg)))
	{
	   value2_reg = fail_reg;
	   value1_reg = void_value;
	   pc = (Function) apply_cont2;

	}
      else
	{
	   k_reg =
	      PJScheme.make_cont2 ((object) symbol ("<cont2-75>"),
				   (object) filenames_reg, (object) env_reg,
				   (object) info_reg, (object) handler_reg,
				   (object) k_reg);
	   filename_reg = PJScheme.car ((object) filenames_reg);
	   pc = (Function) load_file;

	}

   }

   new public static void length_loop ()
   {
      if (true_q (PJScheme.null_q ((object) x_reg)))
	{
	   value2_reg = fail_reg;
	   value1_reg = sum_reg;
	   k_reg = k2_reg;
	   pc = (Function) apply_cont2;

	}
      else
	 if (true_q
	     (PJScheme.not ((object) PJScheme.pair_q ((object) x_reg))))
	{
	   msg_reg =
	      PJScheme.format ((object) "length called on improper list ~s",
			       (object) ls_reg);
	   pc = (Function) runtime_error;

	}
      else
	{
	   sum_reg = PJScheme.Add ((object) sum_reg, (object) 1);
	   x_reg = PJScheme.cdr ((object) x_reg);
	   pc = (Function) length_loop;

	}

   }

   new public static void equal_objects_q ()
   {
      if (true_q
	  ((((bool)
	     (((bool) PJScheme.null_q ((object) x_reg))
	      && ((bool) PJScheme.null_q ((object) y_reg))))
	    ||
	    ((bool)
	     (((bool) PJScheme.boolean_q ((object) x_reg))
	      && ((bool) PJScheme.boolean_q ((object) y_reg))
	      &&
	      ((bool)
	       (((bool) (((bool) x_reg) && ((bool) y_reg)))
		||
		((bool)
		 (((bool) PJScheme.not ((object) x_reg))
		  && ((bool) PJScheme.not ((object) y_reg))))))))
	    ||
	    ((bool)
	     (((bool) PJScheme.symbol_q ((object) x_reg))
	      && ((bool) PJScheme.symbol_q ((object) y_reg))
	      && ((bool) PJScheme.Eq ((object) x_reg, (object) y_reg))))
	    ||
	    ((bool)
	     (((bool) PJScheme.number_q ((object) x_reg))
	      && ((bool) PJScheme.number_q ((object) y_reg))
	      && ((bool) PJScheme.
		  EqualSign ((object) x_reg, (object) y_reg))))
	    ||
	    ((bool)
	     (((bool) PJScheme.char_q ((object) x_reg))
	      && ((bool) PJScheme.char_q ((object) y_reg))
	      && ((bool) PJScheme.
		  char_is__q ((object) x_reg, (object) y_reg))))
	    ||
	    ((bool)
	     (((bool) PJScheme.string_q ((object) x_reg))
	      && ((bool) PJScheme.string_q ((object) y_reg))
	      && ((bool) PJScheme.
		  string_is__q ((object) x_reg, (object) y_reg)))))))
	{
	   value_reg = true;
	   pc = (Function) apply_cont;

	}
      else
	 if (true_q
	     ((((bool) PJScheme.pair_q ((object) x_reg))
	       && ((bool) PJScheme.pair_q ((object) y_reg)))))
	{
	   k_reg =
	      PJScheme.make_cont ((object) symbol ("<cont-37>"),
				  (object) x_reg, (object) y_reg,
				  (object) k_reg);
	   y_reg = PJScheme.car ((object) y_reg);
	   x_reg = PJScheme.car ((object) x_reg);
	   pc = (Function) equal_objects_q;

	}
      else
	 if (true_q
	     ((((bool) PJScheme.vector_q ((object) x_reg))
	       && ((bool) PJScheme.vector_q ((object) y_reg))
	       && ((bool) PJScheme.
		   EqualSign ((object) PJScheme.
			      vector_length ((object) x_reg),
			      (object) PJScheme.
			      vector_length ((object) y_reg))))))
	{
	   i_reg =
	      PJScheme.Subtract ((object) PJScheme.
				 vector_length ((object) x_reg), (object) 1);
	   v2_reg = y_reg;
	   v1_reg = x_reg;
	   pc = (Function) equal_vectors_q;

	}
      else
	{
	   value_reg = false;
	   pc = (Function) apply_cont;

	}

   }

   new public static void equal_vectors_q ()
   {
      if (true_q (PJScheme.LessThan ((object) i_reg, (object) 0)))
	{
	   value_reg = true;
	   pc = (Function) apply_cont;

	}
      else
	{
	   k_reg =
	      PJScheme.make_cont ((object) symbol ("<cont-38>"),
				  (object) i_reg, (object) v1_reg,
				  (object) v2_reg, (object) k_reg);
	   y_reg = PJScheme.vector_ref ((object) v2_reg, (object) i_reg);
	   x_reg = PJScheme.vector_ref ((object) v1_reg, (object) i_reg);
	   pc = (Function) equal_objects_q;

	}

   }

   new public static void member_loop ()
   {
      if (true_q (PJScheme.null_q ((object) y_reg)))
	{
	   value2_reg = fail_reg;
	   value1_reg = false;
	   pc = (Function) apply_cont2;

	}
      else
	 if (true_q
	     (PJScheme.not ((object) PJScheme.pair_q ((object) y_reg))))
	{
	   msg_reg =
	      PJScheme.format ((object) "member called on improper list ~s",
			       (object) ls_reg);
	   pc = (Function) runtime_error;

	}
      else
	{
	   k_reg =
	      PJScheme.make_cont ((object) symbol ("<cont-39>"),
				  (object) ls_reg, (object) x_reg,
				  (object) y_reg, (object) info_reg,
				  (object) handler_reg, (object) fail_reg,
				  (object) k_reg);
	   y_reg = PJScheme.car ((object) y_reg);
	   pc = (Function) equal_objects_q;

	}

   }

   new public static void get_primitive ()
   {
      {
	 object sym = null;
	 sym = PJScheme.car ((object) args_reg);
	 k_reg =
	    PJScheme.make_cont2 ((object) symbol ("<cont2-77>"),
				 (object) args_reg, (object) sym,
				 (object) info_reg, (object) handler_reg,
				 (object) k_reg);
	 var_info_reg = symbol ("none");
	 variable_reg = sym;
	 pc = (Function) lookup_value;
      }

   }

   new public static void append2 ()
   {
      if (true_q (PJScheme.null_q ((object) ls1_reg)))
	{
	   value_reg = ls2_reg;
	   pc = (Function) apply_cont;

	}
      else
	{
	   k_reg =
	      PJScheme.make_cont ((object) symbol ("<cont-40>"),
				  (object) ls1_reg, (object) k_reg);
	   ls1_reg = PJScheme.cdr ((object) ls1_reg);
	   pc = (Function) append2;

	}

   }

   new public static void append_all ()
   {
      if (true_q (PJScheme.null_q ((object) lists_reg)))
	{
	   value_reg = EmptyList;
	   pc = (Function) apply_cont;

	}
      else
	 if (true_q
	     (PJScheme.null_q ((object) PJScheme.cdr ((object) lists_reg))))
	{
	   value_reg = PJScheme.car ((object) lists_reg);
	   pc = (Function) apply_cont;

	}
      else
	{
	   k_reg =
	      PJScheme.make_cont ((object) symbol ("<cont-41>"),
				  (object) lists_reg, (object) k_reg);
	   lists_reg = PJScheme.cdr ((object) lists_reg);
	   pc = (Function) append_all;

	}

   }

   new public static object dir (object args, object env)
   {
      return ((object) PJScheme.
	      sort ((Predicate2) symbolLessThan_q,
		    (object) ((PJScheme.null_q ((object) args)) ? (PJScheme.
								   flatten ((object) PJScheme.append ((object) PJScheme.get_reserved_keywords (), (object) map (get_variables_from_frame_proc, (object) PJScheme.frames ((object) macro_env)), (object) map (get_variables_from_frame_proc, (object) PJScheme.frames ((object) env))))) : (PJScheme.get_variables_from_frame ((object) PJScheme.car ((object) PJScheme.frames ((object) PJScheme.car ((object) args))))))));
   }

   new public static object get_variables_from_frame (object frame)
   {
      return ((object) map (binding_variable_proc, (object) frame));
   }

   new public static bool symbolLessThan_q (object a, object b)
   {
      {
	 object a_string = null;
	 object b_string = null;
	 b_string = PJScheme.symbol_to_string ((object) b);
	 a_string = PJScheme.symbol_to_string ((object) a);
	 return ((bool) PJScheme.
		 stringLessThan_q ((object) a_string, (object) b_string));
      }

   }

   new public static object flatten (object lists)
   {
      if (true_q (PJScheme.null_q ((object) lists)))
	 return ((object) EmptyList);
      else
	 if (true_q
	     (PJScheme.list_q ((object) PJScheme.car ((object) lists))))
	 return ((object) PJScheme.
		 append ((object) PJScheme.
			 flatten ((object) PJScheme.car ((object) lists)),
			 (object) PJScheme.flatten ((object) PJScheme.
						    cdr ((object) lists))));
      else
	 return ((object) PJScheme.
		 cons ((object) PJScheme.car ((object) lists),
		       (object) PJScheme.flatten ((object) PJScheme.
						  cdr ((object) lists))));
   }

   new public static void map_primitive ()
   {
      if (true_q
	  (PJScheme.iterator_q ((object) PJScheme.car ((object) args_reg))))
	{
	   generator_reg = PJScheme.car ((object) args_reg);
	   pc = (Function) iterate_collect;

	}
      else
	{
	   object len = null;
	   object list_args = null;
	   list_args = PJScheme.listify ((object) args_reg);
	   len = PJScheme.length ((object) args_reg);
	   if (true_q (PJScheme.EqualSign ((object) len, (object) 1)))
	     {
		list1_reg = PJScheme.car ((object) list_args);
		pc = (Function) map1;

	     }
	   else if (true_q (PJScheme.EqualSign ((object) len, (object) 2)))
	     {
		list2_reg = PJScheme.cadr ((object) list_args);
		list1_reg = PJScheme.car ((object) list_args);
		pc = (Function) map2;

	     }
	   else
	     {
		lists_reg = list_args;
		pc = (Function) mapN;

	     }
	}

   }

   new public static object listify (object arg_list)
   {
      if (true_q (PJScheme.null_q ((object) arg_list)))
	 return ((object) EmptyList);
      else
	 if (true_q
	     (PJScheme.list_q ((object) PJScheme.car ((object) arg_list))))
	 return ((object) PJScheme.
		 cons ((object) PJScheme.car ((object) arg_list),
		       (object) PJScheme.listify ((object) PJScheme.
						  cdr ((object) arg_list))));
      else
	 if (true_q
	     (PJScheme.vector_q ((object) PJScheme.car ((object) arg_list))))
	 return ((object) PJScheme.
		 cons ((object) PJScheme.
		       vector_to_list ((object) PJScheme.
				       car ((object) arg_list)),
		       (object) PJScheme.listify ((object) PJScheme.
						  cdr ((object) arg_list))));
      else
	 if (true_q
	     (PJScheme.string_q ((object) PJScheme.car ((object) arg_list))))
	 return ((object) PJScheme.
		 cons ((object) PJScheme.
		       string_to_list ((object) PJScheme.
				       car ((object) arg_list)),
		       (object) PJScheme.listify ((object) PJScheme.
						  cdr ((object) arg_list))));
      else
	 throw new
	    Exception (format
		       (symbol ("map") + ": " +
			"cannot use object type '~a' in map",
			PJScheme.get_type ((object) PJScheme.
					   car ((object) arg_list))));
   }

   new public static void iterate ()
   {
      {
	 object iterator = null;
	 iterator = PJScheme.get_iterator ((object) generator_reg);
	 iterator_reg = iterator;
	 pc = (Function) iterate_continue;
      }

   }

   new public static void iterate_continue ()
   {
      {
	 object item = null;
	 item = PJScheme.next_item ((object) iterator_reg);
	 if (true_q (PJScheme.null_q ((object) item)))
	   {
	      value2_reg = fail_reg;
	      value1_reg = EmptyList;
	      pc = (Function) apply_cont2;

	   }
	 else
	   {
	      k2_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-78>"),
				      (object) iterator_reg,
				      (object) proc_reg, (object) env_reg,
				      (object) handler_reg, (object) k_reg);
	      info_reg = symbol ("none");
	      env2_reg = env_reg;
	      args_reg = PJScheme.list ((object) item);
	      pc = (Function) apply_proc;

	   }
      }

   }

   new public static void iterate_collect ()
   {
      {
	 object iterator = null;
	 iterator = PJScheme.get_iterator ((object) generator_reg);
	 iterator_reg = iterator;
	 pc = (Function) iterate_collect_continue;
      }

   }

   new public static void iterate_collect_continue ()
   {
      {
	 object item = null;
	 item = PJScheme.next_item ((object) iterator_reg);
	 if (true_q (PJScheme.null_q ((object) item)))
	   {
	      value2_reg = fail_reg;
	      value1_reg = EmptyList;
	      pc = (Function) apply_cont2;

	   }
	 else
	   {
	      k2_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-79>"),
				      (object) iterator_reg,
				      (object) proc_reg, (object) env_reg,
				      (object) handler_reg, (object) k_reg);
	      info_reg = symbol ("none");
	      env2_reg = env_reg;
	      args_reg = PJScheme.list ((object) item);
	      pc = (Function) apply_proc;

	   }
      }

   }

   new public static void map1 ()
   {
      if (true_q (PJScheme.null_q ((object) list1_reg)))
	{
	   value2_reg = fail_reg;
	   value1_reg = EmptyList;
	   pc = (Function) apply_cont2;

	}
      else if (true_q (PJScheme.dlr_exp_q ((object) proc_reg)))
	{
	   k_reg =
	      PJScheme.make_cont2 ((object) symbol ("<cont2-81>"),
				   (object) list1_reg, (object) proc_reg,
				   (object) k_reg);
	   list1_reg = PJScheme.cdr ((object) list1_reg);
	   pc = (Function) map1;

	}
      else
	{
	   k2_reg =
	      PJScheme.make_cont2 ((object) symbol ("<cont2-80>"),
				   (object) list1_reg, (object) proc_reg,
				   (object) env_reg, (object) handler_reg,
				   (object) k_reg);
	   info_reg = symbol ("none");
	   env2_reg = env_reg;
	   args_reg =
	      PJScheme.list ((object) PJScheme.car ((object) list1_reg));
	   pc = (Function) apply_proc;

	}

   }

   new public static void map2 ()
   {
      if (true_q (PJScheme.null_q ((object) list1_reg)))
	{
	   value2_reg = fail_reg;
	   value1_reg = EmptyList;
	   pc = (Function) apply_cont2;

	}
      else if (true_q (PJScheme.dlr_exp_q ((object) proc_reg)))
	{
	   k_reg =
	      PJScheme.make_cont2 ((object) symbol ("<cont2-83>"),
				   (object) list1_reg, (object) list2_reg,
				   (object) proc_reg, (object) k_reg);
	   list2_reg = PJScheme.cdr ((object) list2_reg);
	   list1_reg = PJScheme.cdr ((object) list1_reg);
	   pc = (Function) map2;

	}
      else
	{
	   k2_reg =
	      PJScheme.make_cont2 ((object) symbol ("<cont2-82>"),
				   (object) list1_reg, (object) list2_reg,
				   (object) proc_reg, (object) env_reg,
				   (object) handler_reg, (object) k_reg);
	   info_reg = symbol ("none");
	   env2_reg = env_reg;
	   args_reg =
	      PJScheme.list ((object) PJScheme.car ((object) list1_reg),
			     (object) PJScheme.car ((object) list2_reg));
	   pc = (Function) apply_proc;

	}

   }

   new public static void mapN ()
   {
      if (true_q
	  (PJScheme.null_q ((object) PJScheme.car ((object) lists_reg))))
	{
	   value2_reg = fail_reg;
	   value1_reg = EmptyList;
	   pc = (Function) apply_cont2;

	}
      else if (true_q (PJScheme.dlr_exp_q ((object) proc_reg)))
	{
	   k_reg =
	      PJScheme.make_cont2 ((object) symbol ("<cont2-85>"),
				   (object) lists_reg, (object) proc_reg,
				   (object) k_reg);
	   lists_reg = map (cdr_proc, (object) lists_reg);
	   pc = (Function) mapN;

	}
      else
	{
	   k2_reg =
	      PJScheme.make_cont2 ((object) symbol ("<cont2-84>"),
				   (object) lists_reg, (object) proc_reg,
				   (object) env_reg, (object) handler_reg,
				   (object) k_reg);
	   info_reg = symbol ("none");
	   env2_reg = env_reg;
	   args_reg = map (car_proc, (object) lists_reg);
	   pc = (Function) apply_proc;

	}

   }

   new public static void for_each_primitive ()
   {
      if (true_q
	  (PJScheme.iterator_q ((object) PJScheme.car ((object) lists_reg))))
	{
	   generator_reg = PJScheme.car ((object) lists_reg);
	   pc = (Function) iterate;

	}
      else
	{
	   object arg_list = null;
	   arg_list = PJScheme.listify ((object) lists_reg);
	   if (true_q
	       (PJScheme.null_q ((object) PJScheme.car ((object) arg_list))))
	     {
		value2_reg = fail_reg;
		value1_reg = void_value;
		pc = (Function) apply_cont2;

	     }
	   else if (true_q (PJScheme.dlr_exp_q ((object) proc_reg)))
	     {
		PJScheme.dlr_apply ((object) proc_reg,
				    (object) map (car_proc,
						  (object) arg_list));
		lists_reg = map (cdr_proc, (object) arg_list);
		pc = (Function) for_each_primitive;

	     }
	   else
	     {
		k2_reg =
		   PJScheme.make_cont2 ((object) symbol ("<cont2-86>"),
					(object) arg_list, (object) proc_reg,
					(object) env_reg,
					(object) handler_reg, (object) k_reg);
		info_reg = symbol ("none");
		env2_reg = env_reg;
		args_reg = map (car_proc, (object) arg_list);
		pc = (Function) apply_proc;

	     }
	}

   }

   new public static object make_toplevel_env ()
   {
      return ((object) PJScheme.
	      make_initial_env_extended ((object) PJScheme.
					 make_initial_environment ((object)
								   PJScheme.
								   list ((object) symbol ("void"), (object) symbol ("exit"), (object) symbol ("eval"), (object) symbol ("parse"), (object) symbol ("parse-string"), (object) symbol ("read-string"), (object) symbol ("apply"), (object) symbol ("sqrt"), (object) symbol ("print"), (object) symbol ("display"), (object) symbol ("newline"), (object) symbol ("load"), (object) symbol ("length"), (object) symbol ("symbol?"), (object) symbol ("number?"), (object) symbol ("boolean?"), (object) symbol ("string?"), (object) symbol ("null?"), (object) symbol ("pair?"), (object) symbol ("cons"), (object) symbol ("car"), (object) symbol ("cdr"), (object) symbol ("cadr"), (object) symbol ("caddr"), (object) symbol ("list"), (object) symbol ("+"), (object) symbol ("-"), (object) symbol ("*"), (object) symbol ("/"), (object) symbol ("<"), (object) symbol (">"), (object) symbol ("="), (object) symbol ("=?"), (object) symbol ("abs"), (object) symbol ("equal?"), (object) symbol ("eq?"), (object) symbol ("memq"), (object) symbol ("member"), (object) symbol ("range"), (object) symbol ("set-car!"), (object) symbol ("set-cdr!"), (object) symbol ("import"), (object) symbol ("get"), (object) symbol ("call-with-current-continuation"), (object) symbol ("call/cc"), (object) symbol ("abort"), (object) symbol ("require"), (object) symbol ("cut"), (object) symbol ("reverse"), (object) symbol ("append"), (object) symbol ("list->vector"), (object) symbol ("dir"), (object) symbol ("current-time"), (object) symbol ("map"), (object) symbol ("for-each"), (object) symbol ("env"), (object) symbol ("using"), (object) symbol ("not"), (object) symbol ("printf"), (object) symbol ("vector"), (object) symbol ("vector-set!"), (object) symbol ("vector-ref"), (object) symbol ("make-vector"), (object) symbol ("<="), (object) symbol (">="), (object) symbol ("error"), (object) symbol ("list-ref")), (object) PJScheme.list ((object) void_prim, (object) exit_prim, (object) eval_prim, (object) parse_prim, (object) parse_string_prim, (object) read_string_prim, (object) apply_prim, (object) sqrt_prim, (object) print_prim, (object) display_prim, (object) newline_prim, (object) load_prim, (object) length_prim, (object) symbol_q_prim, (object) number_q_prim, (object) boolean_q_prim, (object) string_q_prim, (object) null_q_prim, (object) pair_q_prim, (object) cons_prim, (object) car_prim, (object) cdr_prim, (object) cadr_prim, (object) caddr_prim, (object) list_prim, (object) plus_prim, (object) minus_prim, (object) times_prim, (object) divide_prim, (object) lt_prim, (object) gt_prim, (object) equal_sign_prim, (object) equal_sign_prim, (object) abs_prim, (object) equal_q_prim, (object) eq_q_prim, (object) memq_prim, (object) member_prim, (object) range_prim, (object) set_car_b_prim, (object) set_cdr_b_prim, (object) import_prim, (object) get_prim, (object) call_cc_prim, (object) call_cc_prim, (object) abort_prim, (object) require_prim, (object) cut_prim, (object) reverse_prim, (object) append_prim, (object) list_to_vector_prim, (object) dir_prim, (object) current_time_prim, (object) map_prim, (object) for_each_prim, (object) env_prim, (object) using_primitive, (object) not_prim, (object) printf_primitive, (object) vector_prim, (object) vector_set_b_prim, (object) vector_ref_prim, (object) make_vector_prim, (object) lt_or_eq_prim, (object) gt_or_eq_prim, (object) error_prim, (object) list_ref_prim))));
   }

   new public static object make_external_proc (object
						external_function_object)
   {
      return ((object) PJScheme.
	      make_proc ((object) symbol ("<proc-69>"),
			 (object) external_function_object));
   }

   new public static bool pattern_q (object x)
   {
      return ((bool)
	      (((bool) PJScheme.null_q ((object) x))
	       || ((bool) PJScheme.number_q ((object) x))
	       || ((bool) PJScheme.boolean_q ((object) x))
	       || ((bool) PJScheme.symbol_q ((object) x))
	       ||
	       ((bool)
		(((bool) PJScheme.pair_q ((object) x))
		 && ((bool) PJScheme.
		     pattern_q ((object) PJScheme.car ((object) x)))
		 && ((bool) PJScheme.
		     pattern_q ((object) PJScheme.cdr ((object) x)))))));
   }

   new public static bool pattern_variable_q (object x)
   {
      return ((bool)
	      (((bool) PJScheme.symbol_q ((object) x))
	       && ((bool) PJScheme.
		   Equal ((object) "?",
			  (object) PJScheme.substring ((object) PJScheme.
						       symbol_to_string ((object) x), (object) 0, (object) 1)))));
   }

   new public static bool constant_q (object x)
   {
      return ((bool)
	      (((bool) PJScheme.
		not ((object) PJScheme.pattern_variable_q ((object) x)))
	       && ((bool) PJScheme.
		   not ((object) PJScheme.pair_q ((object) x)))));
   }

   new public static void occurs_q ()
   {
      if (true_q (PJScheme.constant_q ((object) pattern_reg)))
	{
	   value_reg = false;
	   pc = (Function) apply_cont;

	}
      else if (true_q (PJScheme.pattern_variable_q ((object) pattern_reg)))
	{
	   value_reg =
	      PJScheme.Equal ((object) var_reg, (object) pattern_reg);
	   pc = (Function) apply_cont;

	}
      else
	{
	   k_reg =
	      PJScheme.make_cont ((object) symbol ("<cont-42>"),
				  (object) pattern_reg, (object) var_reg,
				  (object) k_reg);
	   pattern_reg = PJScheme.car ((object) pattern_reg);
	   pc = (Function) occurs_q;

	}

   }

   new public static void unify_patterns_hat ()
   {
      if (true_q (PJScheme.pattern_variable_q ((object) p1_reg)))
	 if (true_q (PJScheme.pattern_variable_q ((object) p2_reg)))
	   {
	      value_reg =
		 PJScheme.make_sub ((object) symbol ("unit"), (object) p1_reg,
				    (object) p2_reg, (object) ap2_reg);
	      pc = (Function) apply_cont;

	   }
	 else
	   {
	      k_reg =
		 PJScheme.make_cont ((object) symbol ("<cont-43>"),
				     (object) ap2_reg, (object) p1_reg,
				     (object) p2_reg, (object) k_reg);
	      pattern_reg = p2_reg;
	      var_reg = p1_reg;
	      pc = (Function) occurs_q;

	   }
      else if (true_q (PJScheme.pattern_variable_q ((object) p2_reg)))
	{
	   temp_1 = p2_reg;
	   temp_2 = p1_reg;
	   temp_3 = ap2_reg;
	   temp_4 = ap1_reg;
	   p1_reg = temp_1;
	   p2_reg = temp_2;
	   ap1_reg = temp_3;
	   ap2_reg = temp_4;
	   pc = (Function) unify_patterns_hat;

	}
      else
	 if (true_q
	     ((((bool) PJScheme.constant_q ((object) p1_reg))
	       && ((bool) PJScheme.constant_q ((object) p2_reg))
	       && ((bool) PJScheme.
		   Equal ((object) p1_reg, (object) p2_reg)))))
	{
	   value_reg = PJScheme.make_sub ((object) symbol ("empty"));
	   pc = (Function) apply_cont;

	}
      else
	 if (true_q
	     ((((bool) PJScheme.pair_q ((object) p1_reg))
	       && ((bool) PJScheme.pair_q ((object) p2_reg)))))
	{
	   apair2_reg = ap2_reg;
	   apair1_reg = ap1_reg;
	   pair2_reg = p2_reg;
	   pair1_reg = p1_reg;
	   pc = (Function) unify_pairs_hat;

	}
      else
	{
	   value_reg = false;
	   pc = (Function) apply_cont;

	}

   }

   new public static void unify_pairs_hat ()
   {
      k_reg =
	 PJScheme.make_cont ((object) symbol ("<cont-45>"),
			     (object) apair1_reg, (object) apair2_reg,
			     (object) pair1_reg, (object) pair2_reg,
			     (object) k_reg);
      ap2_reg = PJScheme.car_hat ((object) apair2_reg);
      ap1_reg = PJScheme.car_hat ((object) apair1_reg);
      p2_reg = PJScheme.car ((object) pair2_reg);
      p1_reg = PJScheme.car ((object) pair1_reg);
      pc = (Function) unify_patterns_hat;

   }

   new public static void instantiate_hat ()
   {
      if (true_q (PJScheme.constant_q ((object) pattern_reg)))
	{
	   value2_reg = ap_reg;
	   value1_reg = pattern_reg;
	   k_reg = k2_reg;
	   pc = (Function) apply_cont2;

	}
      else if (true_q (PJScheme.pattern_variable_q ((object) pattern_reg)))
	{
	   avar_reg = ap_reg;
	   var_reg = pattern_reg;
	   pc = (Function) apply_sub_hat;

	}
      else if (true_q (PJScheme.pair_q ((object) pattern_reg)))
	{
	   k2_reg =
	      PJScheme.make_cont2 ((object) symbol ("<cont2-90>"),
				   (object) ap_reg, (object) pattern_reg,
				   (object) s_reg, (object) k2_reg);
	   ap_reg = PJScheme.car_hat ((object) ap_reg);
	   pattern_reg = PJScheme.car ((object) pattern_reg);
	   pc = (Function) instantiate_hat;

	}
      else
	 throw new
	    Exception (format
		       (symbol ("instantiate^") + ": " + "bad pattern: ~a",
			pattern_reg));
   }

   new public static object make_sub (params object[]args)
   {
      return ((object) PJScheme.
	      cons ((object) symbol ("substitution"), (object) args));
   }

   new public static void apply_sub_hat ()
   {
      {
	 object temp_1 = null;
	 temp_1 = PJScheme.cdr ((object) s_reg);
	 if (true_q
	     (PJScheme.
	      Eq ((object) PJScheme.car ((object) temp_1),
		  (object) symbol ("empty"))))
	   {
	      value2_reg = avar_reg;
	      value1_reg = var_reg;
	      k_reg = k2_reg;
	      pc = (Function) apply_cont2;

	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("unit"))))
	   {
	      object new_var = null;
	      object new_pattern = null;
	      object new_apattern = null;
	      new_apattern = PJScheme.list_ref ((object) temp_1, (object) 3);
	      new_pattern = PJScheme.list_ref ((object) temp_1, (object) 2);
	      new_var = PJScheme.list_ref ((object) temp_1, (object) 1);
	      if (true_q
		  (PJScheme.Equal ((object) var_reg, (object) new_var)))
		{
		   value2_reg = new_apattern;
		   value1_reg = new_pattern;
		   k_reg = k2_reg;
		   pc = (Function) apply_cont2;

		}
	      else
		{
		   value2_reg = avar_reg;
		   value1_reg = var_reg;
		   k_reg = k2_reg;
		   pc = (Function) apply_cont2;

		}
	   }
	 else
	    if (true_q
		(PJScheme.
		 Eq ((object) PJScheme.car ((object) temp_1),
		     (object) symbol ("composite"))))
	   {
	      object s1 = null;
	      object s2 = null;
	      s2 = PJScheme.list_ref ((object) temp_1, (object) 2);
	      s1 = PJScheme.list_ref ((object) temp_1, (object) 1);
	      k2_reg =
		 PJScheme.make_cont2 ((object) symbol ("<cont2-91>"),
				      (object) s2, (object) k2_reg);
	      s_reg = s1;
	      pc = (Function) apply_sub_hat;
	   }
	 else
	    throw new
	       Exception (format
			  (symbol ("apply-sub^") + ": " +
			   "bad substitution: ~a", s_reg));
      }

   }

   static object chars_to_scan = symbol ("undefined");
   static object scan_line = symbol ("undefined");
   static object scan_char = symbol ("undefined");
   static object scan_position = symbol ("undefined");
   static object last_scan_line = symbol ("undefined");
   static object last_scan_char = symbol ("undefined");
   static object last_scan_position = symbol ("undefined");
   static object token_start_line = symbol ("undefined");
   static object token_start_char = symbol ("undefined");
   static object token_start_position = symbol ("undefined");
   static object let_transformer_hat =
      PJScheme.make_macro ((object) symbol ("<macro-1>"));
   static object letrec_transformer_hat =
      PJScheme.make_macro ((object) symbol ("<macro-2>"));
   static object mit_define_transformer_hat =
      PJScheme.make_macro ((object) symbol ("<macro-3>"));
   static object and_transformer_hat =
      PJScheme.make_macro ((object) symbol ("<macro-4>"));
   static object or_transformer_hat =
      PJScheme.make_macro ((object) symbol ("<macro-5>"));
   static object cond_transformer_hat =
      PJScheme.make_macro ((object) symbol ("<macro-6>"));
   static object let_star_transformer_hat =
      PJScheme.make_macro ((object) symbol ("<macro-7>"));
   static object case_transformer_hat =
      PJScheme.make_macro ((object) symbol ("<macro-8>"));
   static object record_case_transformer_hat =
      PJScheme.make_macro ((object) symbol ("<macro-9>"));
   static object define_datatype_transformer_hat =
      PJScheme.make_macro ((object) symbol ("<macro-10>"));
   static object cases_transformer_hat =
      PJScheme.make_macro ((object) symbol ("<macro-11>"));
   static object macro_env = PJScheme.make_macro_env_hat ();
   static Func < object, bool > quote_q_hat =
      PJScheme.tagged_list_hat ((object) symbol ("quote"),
				(Predicate2) EqualSign, (object) 2);
   static Func < object, bool > quasiquote_q_hat =
      PJScheme.tagged_list_hat ((object) symbol ("quasiquote"),
				(Predicate2) EqualSign, (object) 2);
   static Func < object, bool > unquote_q_hat =
      PJScheme.tagged_list_hat ((object) symbol ("unquote"),
				(Predicate2) GreaterOrEqual, (object) 2);
   static Func < object, bool > unquote_splicing_q_hat =
      PJScheme.tagged_list_hat ((object) symbol ("unquote-splicing"),
				(Predicate2) GreaterOrEqual, (object) 2);
   static Func < object, bool > if_then_q_hat =
      PJScheme.tagged_list_hat ((object) symbol ("if"),
				(Predicate2) EqualSign, (object) 3);
   static Func < object, bool > if_else_q_hat =
      PJScheme.tagged_list_hat ((object) symbol ("if"),
				(Predicate2) EqualSign, (object) 4);
   static Func < object, bool > assignment_q_hat =
      PJScheme.tagged_list_hat ((object) symbol ("set!"),
				(Predicate2) EqualSign, (object) 3);
   static Func < object, bool > func_q_hat =
      PJScheme.tagged_list_hat ((object) symbol ("func"),
				(Predicate2) EqualSign, (object) 2);
   static Func < object, bool > define_q_hat =
      PJScheme.tagged_list_hat ((object) symbol ("define"),
				(Predicate2) GreaterOrEqual, (object) 3);
   static Func < object, bool > define_b_q_hat =
      PJScheme.tagged_list_hat ((object) symbol ("define!"),
				(Predicate2) GreaterOrEqual, (object) 3);
   static Func < object, bool > define_syntax_q_hat =
      PJScheme.tagged_list_hat ((object) symbol ("define-syntax"),
				(Predicate2) GreaterOrEqual, (object) 3);
   static Func < object, bool > begin_q_hat =
      PJScheme.tagged_list_hat ((object) symbol ("begin"),
				(Predicate2) GreaterOrEqual, (object) 2);
   static Func < object, bool > lambda_q_hat =
      PJScheme.tagged_list_hat ((object) symbol ("lambda"),
				(Predicate2) GreaterOrEqual, (object) 3);
   static Func < object, bool > raise_q_hat =
      PJScheme.tagged_list_hat ((object) symbol ("raise"),
				(Predicate2) EqualSign, (object) 2);
   static Func < object, bool > dict_q_hat =
      PJScheme.tagged_list_hat ((object) symbol ("dict"),
				(Predicate2) GreaterOrEqual, (object) 1);
   static Func < object, bool > help_q_hat =
      PJScheme.tagged_list_hat ((object) symbol ("help"),
				(Predicate2) EqualSign, (object) 2);
   static Func < object, bool > choose_q_hat =
      PJScheme.tagged_list_hat ((object) symbol ("choose"),
				(Predicate2) GreaterOrEqual, (object) 1);
   static Func < object, bool > try_q_hat =
      PJScheme.tagged_list_hat ((object) symbol ("try"),
				(Predicate2) GreaterOrEqual, (object) 2);
   static Func < object, bool > catch_q_hat =
      PJScheme.tagged_list_hat ((object) symbol ("catch"),
				(Predicate2) GreaterOrEqual, (object) 3);
   static Func < object, bool > finally_q_hat =
      PJScheme.tagged_list_hat ((object) symbol ("finally"),
				(Predicate2) GreaterOrEqual, (object) 2);
   static object REP_k = PJScheme.make_cont2 ((object) symbol ("<cont2-45>"));
   static object REP_handler =
      PJScheme.make_handler2 ((object) symbol ("<handler2-2>"));
   static object REP_fail = PJScheme.make_fail ((object) symbol ("<fail-1>"));
   static object _starlast_fail_star = REP_fail;
   static object _startokens_left_star = symbol ("undefined");
   static object try_parse_handler =
      PJScheme.make_handler2 ((object) symbol ("<handler2-3>"));
   static object _startracing_on_q_star = true;
   static object void_prim =
      PJScheme.make_proc ((object) symbol ("<proc-3>"));
   static object exit_prim =
      PJScheme.make_proc ((object) symbol ("<proc-4>"));
   static object end_of_session =
      PJScheme.list ((object) symbol ("exiting"), (object) symbol ("the"),
		     (object) symbol ("interpreter"));
   static object eval_prim =
      PJScheme.make_proc ((object) symbol ("<proc-5>"));
   static object parse_prim =
      PJScheme.make_proc ((object) symbol ("<proc-6>"));
   static object parse_string_prim =
      PJScheme.make_proc ((object) symbol ("<proc-7>"));
   static object read_string_prim =
      PJScheme.make_proc ((object) symbol ("<proc-8>"));
   static object apply_prim =
      PJScheme.make_proc ((object) symbol ("<proc-9>"));
   static object sqrt_prim =
      PJScheme.make_proc ((object) symbol ("<proc-10>"));
   static object print_prim =
      PJScheme.make_proc ((object) symbol ("<proc-11>"));
   static object display_prim =
      PJScheme.make_proc ((object) symbol ("<proc-12>"));
   static object newline_prim =
      PJScheme.make_proc ((object) symbol ("<proc-13>"));
   static object load_prim =
      PJScheme.make_proc ((object) symbol ("<proc-14>"));
   static object load_stack = EmptyList;
   static object length_prim =
      PJScheme.make_proc ((object) symbol ("<proc-15>"));
   static object symbol_q_prim =
      PJScheme.make_proc ((object) symbol ("<proc-16>"));
   static object number_q_prim =
      PJScheme.make_proc ((object) symbol ("<proc-17>"));
   static object boolean_q_prim =
      PJScheme.make_proc ((object) symbol ("<proc-18>"));
   static object string_q_prim =
      PJScheme.make_proc ((object) symbol ("<proc-19>"));
   static object null_q_prim =
      PJScheme.make_proc ((object) symbol ("<proc-20>"));
   static object pair_q_prim =
      PJScheme.make_proc ((object) symbol ("<proc-21>"));
   static object cons_prim =
      PJScheme.make_proc ((object) symbol ("<proc-22>"));
   static object car_prim =
      PJScheme.make_proc ((object) symbol ("<proc-23>"));
   static object cdr_prim =
      PJScheme.make_proc ((object) symbol ("<proc-24>"));
   static object cadr_prim =
      PJScheme.make_proc ((object) symbol ("<proc-25>"));
   static object caddr_prim =
      PJScheme.make_proc ((object) symbol ("<proc-26>"));
   static object list_prim =
      PJScheme.make_proc ((object) symbol ("<proc-27>"));
   static object plus_prim =
      PJScheme.make_proc ((object) symbol ("<proc-28>"));
   static object minus_prim =
      PJScheme.make_proc ((object) symbol ("<proc-29>"));
   static object times_prim =
      PJScheme.make_proc ((object) symbol ("<proc-30>"));
   static object divide_prim =
      PJScheme.make_proc ((object) symbol ("<proc-31>"));
   static object lt_prim = PJScheme.make_proc ((object) symbol ("<proc-32>"));
   static object gt_prim = PJScheme.make_proc ((object) symbol ("<proc-33>"));
   static object lt_or_eq_prim =
      PJScheme.make_proc ((object) symbol ("<proc-34>"));
   static object gt_or_eq_prim =
      PJScheme.make_proc ((object) symbol ("<proc-35>"));
   static object equal_sign_prim =
      PJScheme.make_proc ((object) symbol ("<proc-36>"));
   static object abs_prim =
      PJScheme.make_proc ((object) symbol ("<proc-37>"));
   static object equal_q_prim =
      PJScheme.make_proc ((object) symbol ("<proc-38>"));
   static object eq_q_prim =
      PJScheme.make_proc ((object) symbol ("<proc-39>"));
   static object memq_prim =
      PJScheme.make_proc ((object) symbol ("<proc-40>"));
   static object member_prim =
      PJScheme.make_proc ((object) symbol ("<proc-41>"));
   static object range_prim =
      PJScheme.make_proc ((object) symbol ("<proc-42>"));
   static object set_car_b_prim =
      PJScheme.make_proc ((object) symbol ("<proc-43>"));
   static object set_cdr_b_prim =
      PJScheme.make_proc ((object) symbol ("<proc-44>"));
   static object import_prim =
      PJScheme.make_proc ((object) symbol ("<proc-45>"));
   static object get_prim =
      PJScheme.make_proc ((object) symbol ("<proc-46>"));
   static object call_cc_prim =
      PJScheme.make_proc ((object) symbol ("<proc-48>"));
   static object abort_prim =
      PJScheme.make_proc ((object) symbol ("<proc-49>"));
   static object require_prim =
      PJScheme.make_proc ((object) symbol ("<proc-50>"));
   static object cut_prim =
      PJScheme.make_proc ((object) symbol ("<proc-51>"));
   static object reverse_prim =
      PJScheme.make_proc ((object) symbol ("<proc-52>"));
   static object append_prim =
      PJScheme.make_proc ((object) symbol ("<proc-53>"));
   static object list_to_vector_prim =
      PJScheme.make_proc ((object) symbol ("<proc-54>"));
   static object dir_prim =
      PJScheme.make_proc ((object) symbol ("<proc-55>"));
   static object current_time_prim =
      PJScheme.make_proc ((object) symbol ("<proc-56>"));
   static object map_prim =
      PJScheme.make_proc ((object) symbol ("<proc-57>"));
   static object for_each_prim =
      PJScheme.make_proc ((object) symbol ("<proc-58>"));
   static object env_prim =
      PJScheme.make_proc ((object) symbol ("<proc-59>"));
   static object using_primitive =
      PJScheme.make_proc ((object) symbol ("<proc-60>"));
   static object not_prim =
      PJScheme.make_proc ((object) symbol ("<proc-61>"));
   static object printf_primitive =
      PJScheme.make_proc ((object) symbol ("<proc-62>"));
   static object vector_prim =
      PJScheme.make_proc ((object) symbol ("<proc-63>"));
   static object vector_set_b_prim =
      PJScheme.make_proc ((object) symbol ("<proc-64>"));
   static object vector_ref_prim =
      PJScheme.make_proc ((object) symbol ("<proc-65>"));
   static object make_vector_prim =
      PJScheme.make_proc ((object) symbol ("<proc-66>"));
   static object error_prim =
      PJScheme.make_proc ((object) symbol ("<proc-67>"));
   static object list_ref_prim =
      PJScheme.make_proc ((object) symbol ("<proc-68>"));
   static object toplevel_env = PJScheme.make_toplevel_env ();


   static object void_value = null;

   new public static object trampoline ()
   {
      while (pc != null)
	{
	   try
	   {
	      pc ();
	   }
	   catch (Exception e)
	   {
	      if (config.DEBUG > 0)
		{
		   exception_reg = e.ToString ();
		}
	      else
		{
		   string[]parts = get_parts (e.ToString (), NEWLINE_STRING);
		   exception_reg = format ("{0}", parts[0]);
		}
	      pc = (Function) apply_handler2;
	   }
	}
      return (final_reg);
   }

   public static Closure dlr_func (object schemeProc)
   {
      // Return a Csharp function that when invoked acts
      // like schemeProc by calling apply_proc on its args.
      return delegate (object[]args)
      {
	 proc_reg = schemeProc;
	 args_reg = PJScheme.list ((object) args);
	 handler_reg = REP_handler;
	 k2_reg = REP_k;
	 pc = (Function) apply_proc;
	 return PJScheme.trampoline ();
      };
   }
   public static Proc get_variables_from_frame_proc =
      new Proc ("get-variables-from-frame",
		(Procedure1) get_variables_from_frame, 1, 1);
   public static Proc binding_variable_proc =
      new Proc ("binding-variable", (Procedure1) binding_variable, 1, 1);
}

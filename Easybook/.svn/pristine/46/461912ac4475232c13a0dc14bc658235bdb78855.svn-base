package com.therockies.easybook;

//Seongrak Choi
import java.io.IOException;
import java.sql.SQLException;

import javax.servlet.Filter;
import javax.servlet.FilterChain;
import javax.servlet.FilterConfig;
import javax.servlet.ServletException;
import javax.servlet.ServletRequest;
import javax.servlet.ServletResponse;
import javax.servlet.annotation.WebFilter;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;




import ca.on.senecac.prg556.common.StringHelper;

import ca.senecacollege.prg556.limara.bean.AccountOwner;


import com.therockies.easybook.data.AccountOwnerDAOFactory;

/**
 * Servlet Filter implementation class LibraryLoginFilter
 */

public class LibraryLoginFilter implements Filter {

    /**
     * Default constructor. 
     */
    public LibraryLoginFilter() {
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see Filter#destroy()
	 */
	public void destroy() {
		// TODO Auto-generated method stub
	}

	/**
	 * @see Filter#doFilter(ServletRequest, ServletResponse, FilterChain)
	 */
	public void doFilter(ServletRequest req, ServletResponse resp, FilterChain chain) throws IOException, ServletException {
		// TODO Auto-generated method stub
		// place your code here
		
		HttpServletRequest request = (HttpServletRequest)req;
		HttpServletResponse response = (HttpServletResponse)resp;
		HttpSession session = request.getSession();
		
		try
		{
			AccountOwner accountOwner = (AccountOwner)session.getAttribute("accountOwner");
			
			String username = request.getParameter("username");
			String password = request.getParameter("password");
			
			if ("POST".equals(request.getMethod()) && StringHelper.isNotNullOrEmpty(username) && StringHelper.isNotNullOrEmpty(password))
			{
				accountOwner = AccountOwnerDAOFactory.getAccountOwnerDAO().validateAccountOwner(username, password);
				
				if (accountOwner != null)
				{	
					session.setAttribute("accountOwner",accountOwner);
					response.sendRedirect(request.getContextPath() + "/"); // redirect to context root folder
					return;
				}
				else
				{
					request.setAttribute("unsuccessfulLogin", Boolean.TRUE);
					request.setAttribute("username", StringHelper.xmlEscape(username));
				}
			}
			chain.doFilter(req, resp); // continue on to login.jspx
		}
		catch (SQLException sqle)
		{
			throw new ServletException(sqle);
		}
	}

	/**
	 * @see Filter#init(FilterConfig)
	 */
	public void init(FilterConfig fConfig) throws ServletException {
		// TODO Auto-generated method stub
	}

}

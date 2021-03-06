package ca.dmay.easybook;

import java.io.IOException;

import javax.servlet.Filter;
import javax.servlet.FilterChain;
import javax.servlet.FilterConfig;
import javax.servlet.ServletException;
import javax.servlet.ServletRequest;
import javax.servlet.ServletResponse;
import javax.servlet.annotation.WebFilter;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import ca.senecacollege.prg556.limara.bean.AccountOwner;

// Darien May

/**
 * Servlet Filter implementation class AccountAccessFilter
 */
//Filter specified in web.xml
//@WebFilter("/AccountAccessFilter")
public class AccountAccessFilter implements Filter {

    /**
     * Default constructor. 
     */
    public AccountAccessFilter() {

    }

	/**
	 * @see Filter#destroy()
	 */
	public void destroy() {

	}

	/**
	 * @see Filter#doFilter(ServletRequest, ServletResponse, FilterChain)
	 */
	public void doFilter(ServletRequest request, ServletResponse response, FilterChain chain) throws IOException, ServletException {
		// TODO update session scope object with correct name
		HttpServletRequest req = (HttpServletRequest)request;
		String loginPage = req.getContextPath() + "/librarylogin.jspx";
		if (null == req.getSession().getAttribute("accountOwner") && !loginPage.equals(req.getRequestURI())) // if there is no accountOwner obj in the request scope and the destination is not the login page
		{
			((HttpServletResponse)response).sendRedirect(loginPage);
		}
		else
		{
			chain.doFilter(req, response);
		}
	}

	/**
	 * @see Filter#init(FilterConfig)
	 */
	public void init(FilterConfig fConfig) throws ServletException {

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Text.RegularExpressions;

namespace MuxSwt
{
  class Comm
  {
    private bool m_connected = false;

    private int m_RsrcMgr = 0;
    private int m_TimeOut = 0;
    private int m_AccessMode = 0;
    private int m_VI = 0;

    public Comm()
    {
      m_connected = false;
    }

    public bool viConnected
    {
      get { return this.m_connected; }
    }

    public void viOpen(string rSrcString)
    {
      if (!m_connected)
      {
        if (visa32.viOpenDefaultRM(out m_RsrcMgr) == visa32.VI_SUCCESS)
        {
          if (visa32.viOpen(m_RsrcMgr, rSrcString, m_AccessMode, m_TimeOut, out m_VI) == visa32.VI_SUCCESS)
          {
            visa32.viSetAttribute(m_VI, visa32.VI_ATTR_TMO_VALUE, 5000);
            m_connected = true;
          }
        }
      }
    }
    
    public void viClose()
    {
      if (m_connected)
      {
        visa32.viClose(m_VI);
        visa32.viClose(m_RsrcMgr);
        m_connected = false;
      }
    }

    public void viQueryf(string theQuery, out string theResp)
    {
      if (m_connected)
      {
        StringBuilder aRsp = new StringBuilder(0xffff);

        string query = theQuery.Trim(' ');
        if (query[query.Length - 1] != '\n')
          query += '\n';

        visa32.viPrintf(m_VI, query);
        visa32.viScanf(m_VI, "%t", aRsp);

        theResp = aRsp.ToString().TrimEnd(new char[] { '\n' });
      }
      else
        theResp = "";
    }

    public void viPrintf(string theCmd)
    {
      if (m_connected)
      {
        string cmd = theCmd.Trim(' ');
        if (cmd[cmd.Length - 1] != '\n')
          cmd += '\n';

        visa32.viPrintf(m_VI, cmd);
      }
    }

    public bool viSystErr(out string theResp)
    {
      bool ret = false;

      theResp = "";
      if (m_connected)
      {
        StringBuilder aRsp = new StringBuilder(0xffff);

        visa32.viPrintf(m_VI, ":syst:err?\n");
        visa32.viScanf(m_VI, "%t", aRsp);

        String tmp = aRsp.ToString();
        tmp.Trim(new char[] { ' ', '\n' });
        if (!Regex.IsMatch(tmp, "No Error", RegexOptions.IgnoreCase))
        {
          // It seems we do have a real error
          theResp = tmp;
          ret = true;
        }
      }

      return ret;
    }
  }
}

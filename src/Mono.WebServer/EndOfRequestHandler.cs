//
// Mono.WebServer.EndOfRequestHandler
//
// Authors:
//	Daniel Lopez Ridruejo
// 	Gonzalo Paniagua Javier
//
// Documentation:
//	Brian Nickel
//
// Copyright (c) 2002 Daniel Lopez Ridruejo.
//           (c) 2002,2003 Ximian, Inc.
//           All rights reserved.
// (C) Copyright 2004-2010 Novell, Inc. (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Collections;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Hosting;

namespace Mono.WebServer
{
	/// <summary>
	///    This delegate is used to handle <see
	///    cref="MonoWorkerRequest.EndOfRequestEvent" />.
	/// </summary>
	/// <param name="request">
	///    The <see cref="MonoWorkerRequest" /> that sent the event.
	/// </param>
	public delegate void EndOfRequestHandler (MonoWorkerRequest request);
}
